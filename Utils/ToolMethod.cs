using Org.BouncyCastle.Asn1.X9;
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

        public static bool GetRandomBoolean(int x)
        {
            Random random = new Random();
            int randomNumber = random.Next(100);
            return randomNumber < x;
        }
        public static ushort CalculateCRC(byte[] data)
        {
            ushort crc = 0xFFFF;
            for (int i = 0; i < data.Length; i++)
            {
                crc ^= (ushort)data[i];
                for (int j = 0; j < 8; j++)
                {
                    if ((crc & 0x0001) != 0)
                    {
                        crc >>= 1;
                        crc ^= 0xA001;
                    }
                    else
                    {
                        crc >>= 1;
                    }
                }
            }
            return crc;
        }

        public static string GetErrorInfo(int key) {
            switch (key) {
                case 1:
                    return "非法功能码";
                case 2:
                    return "非法数据地址";
                case 3:
                    return "非法数据值";
                case 4:
                    return "从站设备故障";
                case 5:
                    return "确认";
                case 6:
                    return "从站设备忙";
                case 7:
                    return "存储奇偶校验错误";
                case 8:
                    return "网关路径不可用";
                case 9:
                    return "网关目标设备响应失败";
                default:
                    return null;

            }               

        }

    }
}
