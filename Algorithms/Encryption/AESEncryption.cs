using LittleFancyTool.Utils;
using Org.BouncyCastle.Utilities.Encoders;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoTool.Algorithms
{
    public class AESEncryption : IEncryptionSymmetric
    {

        public string Encrypt(string input, string? key = null, string paddingMode = "PKCS7", int keyLength = 128, string? iv = null, string mode = null, string? outputType = "base64", string? keyIvType = "text")
        {
            using (Aes aesAlg = Aes.Create())
            {
                if (keyIvType == "hex")
                {
                    aesAlg.Key = Hex.Decode(key);
                    aesAlg.IV = Hex.Decode(iv);
                }
                else if (keyIvType == "text")
                {
                    aesAlg.Key = Encoding.UTF8.GetBytes(key);
                    aesAlg.IV = Encoding.UTF8.GetBytes(iv);
                }
                else if (keyIvType == "base64")
                {
                    aesAlg.Key = Convert.FromBase64String(key);
                    aesAlg.IV = Convert.FromBase64String(iv);
                }
                else
                {
                    return "key iv type error";
                }
                aesAlg.Padding = GetAesPaddingMode(paddingMode);
                aesAlg.Mode = ToolMethod.EncryptMode(mode);
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
                        if (outputType == "base64")
                        {
                            return Convert.ToBase64String(encrypted);
                        }
                        else if (outputType == "hex")
                        {
                            return Hex.ToHexString(encrypted);
                        }
                        return "output type error";
                    }
                }
            }
        }

        public string Decrypt(string input, string? key = null, string paddingMode = "PKCS7", int keyLength = 128, string? iv=null, string mode = null, string? outputType = "base64", string? keyIvType = "text")
        {
            using (Aes aesAlg = Aes.Create())
            {
                if (keyIvType == "hex")
                {
                    aesAlg.Key = Hex.Decode(key);
                    aesAlg.IV = Hex.Decode(iv);
                }
                else if (keyIvType == "text")
                {
                    aesAlg.Key = Encoding.UTF8.GetBytes(key);
                    aesAlg.IV = Encoding.UTF8.GetBytes(iv);
                }
                else if (keyIvType == "base64")
                {
                    aesAlg.Key = Convert.FromBase64String(key);
                    aesAlg.IV = Convert.FromBase64String(iv);
                }
                else
                {
                    return "key iv type error";
                }
                aesAlg.Padding = GetAesPaddingMode(paddingMode);
                aesAlg.Mode = ToolMethod.EncryptMode(mode);
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                byte[] cipherBytes;

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

                using (MemoryStream msDecrypt = new MemoryStream(cipherBytes))
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
                return PaddingMode.PKCS7;
            }

            switch (paddingMode)
            {
                case "PKCS7":
                    return PaddingMode.PKCS7;
                case "Zeros":
                    return PaddingMode.Zeros;
                case "None":
                    return PaddingMode.None;
                default:
                    throw new NotSupportedException("不支持的 AES 填充方式");
            }
        }
    }
}
