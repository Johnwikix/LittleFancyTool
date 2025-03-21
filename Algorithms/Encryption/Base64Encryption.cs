﻿using LittleFancyTool.Algorithms;
using System.Text;

namespace CryptoTool.Algorithms
{
    public class Base64Encryption : IEncryptionCode
    {
        public string Encrypt(string input)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(input);
            return Convert.ToBase64String(bytes);
        }

        public string Decrypt(string input)
        {
            byte[] bytes = Convert.FromBase64String(input);
            return Encoding.UTF8.GetString(bytes);
        }
    }
}
