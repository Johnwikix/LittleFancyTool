using CryptoTool.Algorithms;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AntdUI;
using Org.BouncyCastle.Crypto.Paddings;
using Org.BouncyCastle.Utilities.Encoders;
using System.Security.Cryptography;

namespace LittleFancyTool.Algorithms
{
    public class SM4Encryption : IEncryptionAlgorithm
    {
        public string Decrypt(string input, string? key, string? paddingMode, int keyLength, string? iv,string mode)
        {
            byte[] cipherBytes = Encoding.UTF8.GetBytes(input);
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);
            byte[] ivBytes = Encoding.UTF8.GetBytes(iv);

            IBlockCipher engine = new SM4Engine();
            IBufferedCipher cipher;
            IBlockCipherPadding padding = GetPadding(paddingMode);

            if (mode.ToUpper() == "ECB")
            {
                cipher = new PaddedBufferedBlockCipher(engine, padding);
                cipher.Init(false, new KeyParameter(keyBytes));
            }
            else if (mode.ToUpper() == "CBC")
            {
                if (string.IsNullOrEmpty(iv))
                {
                    throw new ArgumentException("使用 CBC 模式时，IV 不能为空。");
                }
                cipher = new PaddedBufferedBlockCipher(new CbcBlockCipher(engine), padding);
                cipher.Init(false, new ParametersWithIV(new KeyParameter(keyBytes), ivBytes));
            }
            else
            {
                throw new ArgumentException($"不支持的加密模式: {mode}。支持的模式有: ECB, CBC。");
            }

            byte[] outputBytes = new byte[cipher.GetOutputSize(cipherBytes.Length)];
            int length = cipher.ProcessBytes(cipherBytes, 0, cipherBytes.Length, outputBytes, 0);
            cipher.DoFinal(outputBytes, length);

            return Encoding.UTF8.GetString(outputBytes);
        }
        public string Encrypt(string input, string? key, string? paddingModeStr, int keyLength, string? iv, string mode)
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);
            byte[] ivBytes = Encoding.UTF8.GetBytes(iv);
            byte[] data = Encoding.UTF8.GetBytes(input);

            IBlockCipher engine = new SM4Engine();
            IBufferedCipher cipher;

            IBlockCipherPadding paddingMode = GetPadding(paddingModeStr);

            if (mode.ToUpper() == "ECB")
            {
                cipher = new PaddedBufferedBlockCipher(engine, new Pkcs7Padding());
                cipher.Init(true, new KeyParameter(keyBytes));
            }
            else if (mode.ToUpper() == "CBC")
            {
                if (string.IsNullOrEmpty(iv))
                {
                    throw new ArgumentException("使用 CBC 模式时，IV 不能为空。");
                }
                cipher = new PaddedBufferedBlockCipher(new CbcBlockCipher(engine), new Pkcs7Padding());
                cipher.Init(true, new ParametersWithIV(new KeyParameter(keyBytes), ivBytes));
            }
            else
            {
                throw new ArgumentException($"不支持的加密模式: {mode}。支持的模式有: ECB, CBC。");
            }
            byte[] outputBytes = new byte[cipher.GetOutputSize(data.Length)];
            int length = cipher.ProcessBytes(data, 0, data.Length, outputBytes, 0);
            cipher.DoFinal(outputBytes, length);
            return Hex.ToHexString(outputBytes);
        }
        private IBlockCipherPadding GetPadding(string paddingMode)
        {
            if (string.IsNullOrEmpty(paddingMode))
            {
                return new Pkcs7Padding();
            }

            switch (paddingMode.ToUpper())
            {
                case "PKCS7":
                    return new Pkcs7Padding();
                case "ISO10126":
                    return new ISO10126d2Padding();
                case "ZEROBYTE":
                    return new ZeroBytePadding();
                default:
                    throw new ArgumentException($"不支持的填充模式: {paddingMode}。支持的模式有: PKCS7, ISO10126, ZEROBYTE。");
            }
        }
    }
}
