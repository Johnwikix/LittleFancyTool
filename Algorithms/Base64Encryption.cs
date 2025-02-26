using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoTool.Algorithms
{
    public class Base64Encryption : IEncryptionAlgorithm
    {
        public string Encrypt(string input, string publicKey = null, string paddingMode = null, int keyLength = 2048,string iv = null)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(input);
            return Convert.ToBase64String(bytes);
        }

        public string Decrypt(string input, string privateKey = null, string paddingMode = null, int keyLength = 2048,string iv = null)
        {
            byte[] bytes = Convert.FromBase64String(input);
            return Encoding.UTF8.GetString(bytes);
        }
    }
}
