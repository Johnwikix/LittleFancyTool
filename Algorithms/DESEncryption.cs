using CryptoTool.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LittleFancyTool.Algorithms
{
    public class DESEncryption : IEncryptionAlgorithm
    {
        public string Encrypt(string input, string key = null, string paddingMode = "PKCS7", int keyLength = 64, string iv = null,  string mode=null)
        {
            using (DES desAlg = DES.Create())
            {
                desAlg.Key = Encoding.UTF8.GetBytes(key);
                desAlg.IV = Encoding.UTF8.GetBytes(iv);
                desAlg.Padding = GetPaddingMode(paddingMode);

                ICryptoTransform encryptor = desAlg.CreateEncryptor(desAlg.Key, desAlg.IV);

                using (System.IO.MemoryStream msEncrypt = new System.IO.MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (System.IO.StreamWriter swEncrypt = new System.IO.StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(input);
                        }
                        byte[] encrypted = msEncrypt.ToArray();
                        return Convert.ToBase64String(encrypted);
                    }
                }
            }
        }

        public string Decrypt(string input, string key = null, string paddingMode = "PKCS7", int keyLength = 64, string iv = null, string mode = null)
        {

            using (DES desAlg = DES.Create())
            {
                desAlg.Key = Encoding.UTF8.GetBytes(key);
                desAlg.IV = Encoding.UTF8.GetBytes(iv);
                desAlg.Padding = GetPaddingMode(paddingMode);

                ICryptoTransform decryptor = desAlg.CreateDecryptor(desAlg.Key, desAlg.IV);

                byte[] cipherText = Convert.FromBase64String(input);

                using (System.IO.MemoryStream msDecrypt = new System.IO.MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (System.IO.StreamReader srDecrypt = new System.IO.StreamReader(csDecrypt))
                        {
                            return srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
        }

        private PaddingMode GetPaddingMode(string paddingMode)
        {
            switch (paddingMode)
            {
                case "PKCS7":
                    return PaddingMode.PKCS7;
                case "None":
                    return PaddingMode.None;
                case "Zeros":
                    return PaddingMode.Zeros;
                default:
                    throw new NotSupportedException("不支持的填充方式");
            }
        }
    }
}
