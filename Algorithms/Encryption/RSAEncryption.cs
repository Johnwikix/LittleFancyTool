using CryptoTool.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LittleFancyTool.Algorithms.Encryption
{
    public class RSAEncryption : IEncryptionAsymmetric
    {
        public string Encrypt(string input, string publicKey = null, string paddingMode = "PKCS#1", int keyLength = 2048)
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

        public string Decrypt(string input, string privateKey = null, string paddingMode = "PKCS#1", int keyLength = 2048)
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

        public async Task EncryptFileAsync(string inputFilePath, string outputFilePath, string publicKey, int keyLength)
        {
            using (var rsa = RSA.Create())
            {
                rsa.ImportFromPem(publicKey);
                using (var inputFileStream = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read))
                using (var outputFileStream = new FileStream(outputFilePath, FileMode.Create, FileAccess.Write))
                {
                    int maxDataSize = keyLength / 8 - 11; // PKCS1填充模式下，最大加密数据块大小
                    byte[] buffer = new byte[maxDataSize];
                    int bytesRead;
                    while ((bytesRead = await inputFileStream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                    {
                        byte[] encryptedData = rsa.Encrypt(buffer, RSAEncryptionPadding.Pkcs1);
                        await outputFileStream.WriteAsync(encryptedData, 0, encryptedData.Length);
                    }
                }
            }
        }

        public async Task DecryptFileAsync(string inputFilePath, string outputFilePath, string privateKey, int keyLength)
        {
            using (var rsa = RSA.Create())
            {

                rsa.ImportFromPem(privateKey);
                using (var inputFileStream = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read))
                using (var outputFileStream = new FileStream(outputFilePath, FileMode.Create, FileAccess.Write))
                {
                    // RSA解密的数据块大小等于密钥长度
                    int encryptedBlockSize = keyLength / 8;
                    byte[] buffer = new byte[encryptedBlockSize];
                    int bytesRead;
                    while ((bytesRead = await inputFileStream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                    {
                        byte[] decryptedData = rsa.Decrypt(buffer, RSAEncryptionPadding.Pkcs1);
                        await outputFileStream.WriteAsync(decryptedData, 0, decryptedData.Length);
                    }
                }
            }
        }
    }
}
