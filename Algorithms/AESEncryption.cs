﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CryptoTool.Algorithms
{
    public class AESEncryption : IEncryptionAlgorithm
    {
        private static readonly byte[] Key = Encoding.UTF8.GetBytes("0123456789ABCDEF");
        private static readonly byte[] IV = Encoding.UTF8.GetBytes("ABCDEF9876543210");

        public string Encrypt(string input, string publicKey = null, string paddingMode = "PKCS7", int keyLength = 2048)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;
                aesAlg.Padding = GetAesPaddingMode(paddingMode);

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(input);
                        }
                        byte[] encrypted = msEncrypt.ToArray();
                        return Convert.ToBase64String(encrypted);
                    }
                }
            }
        }

        public string Decrypt(string input, string privateKey = null, string paddingMode = "PKCS7", int keyLength = 2048)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;
                aesAlg.Padding = GetAesPaddingMode(paddingMode);

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                byte[] cipherText = Convert.FromBase64String(input);

                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            return srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
        }

        private PaddingMode GetAesPaddingMode(string paddingMode)
        {
            if (string.IsNullOrEmpty(paddingMode))
            {
                return PaddingMode.PKCS7; // 默认使用 PKCS7 填充方式
            }

            switch (paddingMode)
            {
                case "PKCS7":
                    return PaddingMode.PKCS7;
                case "Zeros":
                    return PaddingMode.Zeros;
                default:
                    throw new NotSupportedException("不支持的 AES 填充方式");
            }
        }
    }
}
