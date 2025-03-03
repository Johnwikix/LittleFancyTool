using CryptoTool.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LittleFancyTool.Algorithms.Encryption
{
    public class Md5Encryption : IEncryptionAbstract
    {
        public string Decrypt(string input)
        {
            throw new NotImplementedException();
        }

        public string Encrypt(string input,string? useUpperCase = "UPPER", int outputLength = 16,string? mode = null)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                // 将哈希字节数组转换为十六进制字符串
                StringBuilder sb = new StringBuilder();
                string format = useUpperCase == "UPPER" ? "X2" : "x2";
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString(format));
                }
                string hashString = sb.ToString();
                if(outputLength==16)
                {
                    // 对于16位MD5，取第9位到第24位
                    return hashString.Substring(8, 16);
                }
                return hashString;
            }
        }
    }
}
