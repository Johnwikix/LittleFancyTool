﻿using CryptoTool.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LittleFancyTool.Algorithms
{
    public class SHAEncrpytion : IEncryptionAlgorithm
    {
        public string Decrypt(string input, string? key, string? paddingMode, int keyLength, string? iv, string cbcMode = null)
        {
            throw new NotImplementedException();
        }

        public string Encrypt(string input, string? mode, string? upperLowerCase, int keyLength, string? iv, string cbcMode = null)
        {
            using (HashAlgorithm algorithm = GetHashAlgorithm(mode))
            {
                if (algorithm == null)
                {
                    throw new ArgumentException($"不支持的哈希算法: {mode}。支持的算法有: SHA1, SHA256, SHA384, SHA512。");
                }
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = algorithm.ComputeHash(inputBytes);
                string format = upperLowerCase == "UPPER" ? "X2" : "x2";
                // 将哈希字节数组转换为十六进制字符串
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString(format));
                }
                return sb.ToString();
            }
        }

        private static HashAlgorithm GetHashAlgorithm(string algorithmName)
        {
            switch (algorithmName.ToUpper())
            {
                case "SHA1":
                    return SHA1.Create();
                case "SHA256":
                    return SHA256.Create();
                case "SHA384":
                    return SHA384.Create();
                case "SHA512":
                    return SHA512.Create();
                default:
                    return null;
            }
        }

    }
}
