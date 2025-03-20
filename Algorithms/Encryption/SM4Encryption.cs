using CryptoTool.Algorithms;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Paddings;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities.Encoders;
using System.Text;

namespace LittleFancyTool.Algorithms.Encryption
{
    public class SM4Encryption : IEncryptionSymmetric
    {
        public string Decrypt(
            string input,
            string? key, string?
            paddingModeStr,
            int keyLength,
            string? iv,
            string mode,
            string? outputType = "base64",
            string? keyIvType = "text")
        {
            byte[] cipherBytes;
            byte[] keyBytes;
            byte[] ivBytes;
            if (outputType == "base64")
            {
                cipherBytes = Convert.FromBase64String(input);
            }
            else if (outputType == "hex")
            {
                cipherBytes = Hex.Decode(input);
            }
            else
            {
                return "output type error";
            }

            if (keyIvType == "hex")
            {
                keyBytes = Hex.Decode(key);
                ivBytes = Hex.Decode(iv);
            }
            else if (keyIvType == "text")
            {
                keyBytes = Encoding.UTF8.GetBytes(key);
                ivBytes = Encoding.UTF8.GetBytes(iv);
            }
            else if (keyIvType == "base64")
            {
                keyBytes = Convert.FromBase64String(key);
                ivBytes = Convert.FromBase64String(iv);
            }
            else
            {
                return "key iv type error";
            }

            IBlockCipher engine = new SM4Engine();
            IBufferedCipher cipher;
            IBlockCipherPadding padding = GetPadding(paddingModeStr);

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
        public string Encrypt(
            string input,
            string? key,
            string? paddingModeStr,
            int keyLength,
            string? iv,
            string mode,
            string? outputType = "base64",
            string? keyIvType = "text")
        {
            byte[] keyBytes;
            byte[] ivBytes;
            byte[] data = Encoding.UTF8.GetBytes(input);

            if (keyIvType == "hex")
            {
                keyBytes = Hex.Decode(key);
                ivBytes = Hex.Decode(iv);
            }
            else if (keyIvType == "text")
            {
                keyBytes = Encoding.UTF8.GetBytes(key);
                ivBytes = Encoding.UTF8.GetBytes(iv);
            }
            else if (keyIvType == "base64")
            {
                keyBytes = Convert.FromBase64String(key);
                ivBytes = Convert.FromBase64String(iv);
            }
            else
            {
                return "key iv type error";
            }

            IBlockCipher engine = new SM4Engine();
            IBufferedCipher cipher;

            IBlockCipherPadding paddingMode = GetPadding(paddingModeStr);

            if (mode.ToUpper() == "ECB")
            {
                cipher = new PaddedBufferedBlockCipher(engine, paddingMode);
                cipher.Init(true, new KeyParameter(keyBytes));
            }
            else if (mode.ToUpper() == "CBC")
            {
                if (string.IsNullOrEmpty(iv))
                {
                    throw new ArgumentException("使用 CBC 模式时，IV 不能为空。");
                }
                cipher = new PaddedBufferedBlockCipher(new CbcBlockCipher(engine), paddingMode);
                cipher.Init(true, new ParametersWithIV(new KeyParameter(keyBytes), ivBytes));
            }
            else
            {
                throw new ArgumentException($"不支持的加密模式: {mode}。支持的模式有: ECB, CBC。");
            }
            byte[] outputBytes = new byte[cipher.GetOutputSize(data.Length)];
            int length = cipher.ProcessBytes(data, 0, data.Length, outputBytes, 0);
            cipher.DoFinal(outputBytes, length);
            if (outputType == "base64")
            {
                return Convert.ToBase64String(outputBytes);
            }
            else if (outputType == "hex")
            {
                return Hex.ToHexString(outputBytes);
            }
            return "output type error";
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
