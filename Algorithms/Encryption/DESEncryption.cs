using CryptoTool.Algorithms;
using LittleFancyTool.Utils;
using Org.BouncyCastle.Utilities.Encoders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LittleFancyTool.Algorithms
{
    public class DESEncryption : IEncryptionSymmetric
    {
        public string Encrypt(string input, string key = null, string paddingMode = "PKCS7", int keyLength = 64, string iv = null,  string mode=null, string? outputType = "base64", string? keyIvType = "text")
        {
            using (DES desAlg = DES.Create())
            {
                if (keyIvType == "hex")
                {
                    desAlg.Key = Hex.Decode(key);
                    desAlg.IV = Hex.Decode(iv);
                }
                else if (keyIvType == "text")
                {
                    desAlg.Key = Encoding.UTF8.GetBytes(key);
                    desAlg.IV = Encoding.UTF8.GetBytes(iv);
                }
                else if (keyIvType == "base64")
                {
                    desAlg.Key = Convert.FromBase64String(key);
                    desAlg.IV = Convert.FromBase64String(iv);
                }
                else
                {
                    return "key iv type error";
                }
                desAlg.Padding = GetPaddingMode(paddingMode);
                desAlg.Mode = ToolMethod.EncryptMode(mode);

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

        public string Decrypt(string input, string key = null, string paddingMode = "PKCS7", int keyLength = 64, string iv = null, string mode = null, string? outputType = "base64", string? keyIvType = "text")
        {

            using (DES desAlg = DES.Create())
            {
                if (keyIvType == "hex")
                {
                    desAlg.Key = Hex.Decode(key);
                    desAlg.IV = Hex.Decode(iv);
                }
                else if (keyIvType == "text")
                {
                    desAlg.Key = Encoding.UTF8.GetBytes(key);
                    desAlg.IV = Encoding.UTF8.GetBytes(iv);
                }
                else if (keyIvType == "base64")
                {
                    desAlg.Key = Convert.FromBase64String(key);
                    desAlg.IV = Convert.FromBase64String(iv);
                }
                else
                {
                    return "key iv type error";
                }
                desAlg.Padding = GetPaddingMode(paddingMode);
                desAlg.Mode = ToolMethod.EncryptMode(mode);

                ICryptoTransform decryptor = desAlg.CreateDecryptor(desAlg.Key, desAlg.IV);

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

                using (System.IO.MemoryStream msDecrypt = new System.IO.MemoryStream(cipherBytes))
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
