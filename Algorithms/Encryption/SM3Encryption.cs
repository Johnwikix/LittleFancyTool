using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Utilities.Encoders;
using System.Text;

namespace LittleFancyTool.Algorithms.Encryption
{
    public class SM3Encryption : IEncryptionAbstract
    {
        public string Decrypt(string input)
        {
            throw new NotImplementedException();
        }
        public string Encrypt(string input, string? upperLowerCase, int outputLength, string? mode)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            IDigest digest = new SM3Digest();
            digest.BlockUpdate(inputBytes, 0, inputBytes.Length);
            byte[] hashBytes = new byte[digest.GetDigestSize()];
            digest.DoFinal(hashBytes, 0);
            // 将字节数组转换为十六进制字符串
            string hashHex = Hex.ToHexString(hashBytes);
            // 根据 outputUpperCase 参数决定是否转换为大写
            if (upperLowerCase == "UPPER")
            {
                hashHex = hashHex.ToUpper();
            }
            return hashHex;
        }
    }
}
