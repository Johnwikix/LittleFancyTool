using CryptoTool.Algorithms;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Utilities.Encoders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleFancyTool.Algorithms
{
    public class SM3Encryption: IEncryptionAlgorithm
    {
        public string Decrypt(string input, string? key, string? paddingMode, int keyLength, string? iv, string cbcMode = null)
        {
            throw new NotImplementedException();
        }
        public string Encrypt(string input, string? upperLowerCase, string? mode, int keyLength, string? iv, string cbcMode = null)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            IDigest digest = new SM3Digest();
            digest.BlockUpdate(inputBytes, 0, inputBytes.Length);
            byte[] hashBytes = new byte[digest.GetDigestSize()];
            digest.DoFinal(hashBytes, 0);
            // 将字节数组转换为十六进制字符串
            string hashHex = Hex.ToHexString(hashBytes);
            // 根据 outputUpperCase 参数决定是否转换为大写
            if (upperLowerCase=="UPPER")
            {
                hashHex = hashHex.ToUpper();
            }
            return hashHex;
        }
    }
}
