﻿using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.Encoders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LittleFancyTool.Utils
{
    public class ToolMethod
    {
        private const string ValidChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()_+-=[]{}|;':\",./<>?";
        public static string GenerateSymmetricKey(int bitLength, string keyIvType)
        {
            byte[] keyBytes = new byte[bitLength / 8];
            int length;
            switch (bitLength)
            {
                case 64:
                    length = 8;
                    break;
                case 128:
                    length = 16;
                    break;
                case 192:
                    length = 24;
                    break;
                case 256:
                    length = 32;
                    break;
                default:
                    throw new ArgumentException("Invalid bit length. Supported lengths are 64, 128, 192, and 256.");
            }
            if (keyIvType == "text")
            {
                Random random = new Random();
                StringBuilder key = new StringBuilder(bitLength);
                for (int i = 0; i < length; i++)
                {
                    int index = random.Next(0, ValidChars.Length);
                    key.Append(ValidChars[index]);
                }
                return key.ToString();
            }
            if (keyIvType == "base64")
            {
                using (var rng = RandomNumberGenerator.Create())
                {
                    rng.GetBytes(keyBytes);
                }
                return Convert.ToBase64String(keyBytes);
            }
            if (keyIvType == "hex")
            {
                using (var rng = RandomNumberGenerator.Create())
                {
                    rng.GetBytes(keyBytes);
                }
                return Hex.ToHexString(keyBytes);
            }
            return "keyIvType error";

        }

        public static CipherMode EncryptMode(string mode)
        {
            switch (mode)
            {
                case "ECB":
                    return CipherMode.ECB;
                case "CBC":
                    return CipherMode.CBC;
                default:
                    throw new NotSupportedException("不支持的填充方式");
            }
        }
    }
}
