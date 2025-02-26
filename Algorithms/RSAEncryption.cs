using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CryptoTool.Algorithms
{
    public class RSAEncryption : IEncryptionAlgorithm
    {
        public string Encrypt(string input, string publicKey = null, string paddingMode = "PKCS#1", int keyLength = 2048, string iv = null)
        {
            using (RSA rsa = RSA.Create(keyLength))
            {
                rsa.ImportFromPem(publicKey);
                RSAEncryptionPadding padding = GetRSAEncryptionPadding(paddingMode);
                byte[] dataToEncrypt = Encoding.UTF8.GetBytes(input);
                byte[] encryptedData = rsa.Encrypt(dataToEncrypt, padding);
                return Convert.ToBase64String(encryptedData);
            }
        }

        public string Decrypt(string input, string privateKey = null, string paddingMode = "PKCS#1", int keyLength = 2048, string iv = null)
        {
            using (RSA rsa = RSA.Create(keyLength))
            {
                rsa.ImportFromPem(privateKey);
                RSAEncryptionPadding padding = GetRSAEncryptionPadding(paddingMode);
                byte[] encryptedData = Convert.FromBase64String(input);
                byte[] decryptedData = rsa.Decrypt(encryptedData, padding);
                return Encoding.UTF8.GetString(decryptedData);
            }
        }

        public (string publicKey, string privateKey) GenerateKeyPair(int keyLength = 2048,string keyFormat = "PKCS#8")
        {
            using (RSA rsa = RSA.Create(keyLength))
            {
                string privateKeyPem = ExportPrivateKey(rsa,keyFormat);
                string publicKeyPem = ExportPublicKey(rsa,keyFormat);
                return (publicKeyPem, privateKeyPem);
            }
        }

        private static string ExportPrivateKey(RSA rsa, string keyFormat)
        {
            if (keyFormat == "PKCS#8")
            {
                return rsa.ExportPkcs8PrivateKeyPem();
            }
            else if (keyFormat == "PKCS#1")
            {
                return rsa.ExportRSAPrivateKeyPem();
            }
            else {
                throw new ArgumentException("Unsupported private key format", nameof(keyFormat));
            }
        }

        private static string ExportPublicKey(RSA rsa, string keyFormat)
        {
            if (keyFormat == "PKCS#1")
            {
                return rsa.ExportRSAPublicKeyPem();
            }
            else if(keyFormat== "PKCS#8") {
                byte[] pkcs8KeyBytes = rsa.ExportSubjectPublicKeyInfo();
                string pkcs8Base64 = Convert.ToBase64String(pkcs8KeyBytes);
                StringBuilder pkcs8PemBuilder = new StringBuilder();
                pkcs8PemBuilder.AppendLine("-----BEGIN PUBLIC KEY-----");
                for (int i = 0; i < pkcs8Base64.Length; i += 64)
                {
                    pkcs8PemBuilder.AppendLine(pkcs8Base64.Substring(i, Math.Min(64, pkcs8Base64.Length - i)));
                }
                pkcs8PemBuilder.AppendLine("-----END PUBLIC KEY-----");

                return pkcs8PemBuilder.ToString();
            }
            else
            {
                throw new ArgumentException("Unsupported public key format", nameof(keyFormat));
            }
        }

        private RSAEncryptionPadding GetRSAEncryptionPadding(string paddingMode)
        {
            switch (paddingMode)
            {
                case "Pkcs1":
                    return RSAEncryptionPadding.Pkcs1;
                case "OaepSHA1":
                    return RSAEncryptionPadding.OaepSHA1;
                case "OaepSHA256":
                    return RSAEncryptionPadding.OaepSHA256;
                case "OaepSHA384":
                    return RSAEncryptionPadding.OaepSHA384;
                case "OaepSHA512":
                    return RSAEncryptionPadding.OaepSHA512;
                default:
                    throw new NotSupportedException("不支持的填充方式");
            }
        }
    }
}
