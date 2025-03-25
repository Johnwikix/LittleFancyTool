using Org.BouncyCastle.Utilities.Encoders;
using System.Drawing.Imaging;
using System.Security.Cryptography;
using System.Text;

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

        public enum EncodingMode
        {
            Auto,
            UTF8,
            ASCII,
            GB2312
        }

        public static Encoding GetEncoding(EncodingMode encodingMode)
        {
            switch (encodingMode)
            {
                case EncodingMode.Auto:
                    return Encoding.UTF8;
                case EncodingMode.ASCII:
                    return Encoding.ASCII;
                case EncodingMode.UTF8:
                    return Encoding.UTF8;
                case EncodingMode.GB2312:
                    return Encoding.GetEncoding("GB18030");
                default:
                    throw new ArgumentException("不支持的编码类型");
            }
        }

        public static byte[] GetEncodedData(string input, EncodingMode mode)
        {
            switch (mode)
            {
                case EncodingMode.Auto:
                    return Encoding.UTF8.GetBytes(input);
                case EncodingMode.ASCII:
                    return Encoding.ASCII.GetBytes(input);
                case EncodingMode.UTF8:
                    return Encoding.UTF8.GetBytes(input);
                case EncodingMode.GB2312:
                    Encoding gbEncoder = GetGBEncoding();
                    return gbEncoder.GetBytes(input);
                default:
                    throw new ArgumentException("不支持的编码类型");
            }
        }
        private static Encoding GetGBEncoding()
        {
            try
            {
                return Encoding.GetEncoding("GB18030");
            }
            catch (ArgumentException)
            {
                return Encoding.Default;
            }
        }


        public static string GetErrorInfo(int key)
        {
            switch (key)
            {
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

        public static string ByteArrayToHexString(byte[] data)
        {
            return BitConverter.ToString(data).Replace("-", " ");
        }

        public static byte[] HexStringToBytes(string hexStr)
        {
            try
            {
                string hex = hexStr.Replace(" ", "");
                int length = hex.Length;
                byte[] bytes = new byte[length / 2];
                for (int i = 0; i < length; i += 2)
                {
                    bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
                }
                return bytes;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static string CalculateFileHash(string filePath)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filePath))
                {
                    var hashBytes = md5.ComputeHash(stream);
                    return BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant();
                }
            }
        }

        public static bool IsValidFolderPath(string path)
        {
            try
            {
                // 检查路径是否为 null 或空字符串
                if (string.IsNullOrEmpty(path))
                {
                    return false;
                }

                // 检查路径是否包含非法字符
                if (path.IndexOfAny(Path.GetInvalidPathChars()) != -1)
                {
                    return false;
                }

                // 尝试获取父目录，若成功则认为是有效的文件夹路径
                string parentDirectory = Path.GetDirectoryName(path);
                if (parentDirectory != null)
                {
                    return Directory.Exists(parentDirectory);
                }
            }
            catch (ArgumentException)
            {
                return false;
            }
            return false;
        }

        public static bool IsMusicFile(string filePath)
        {
            var extension = Path.GetExtension(filePath).ToLower();
            return new[] { ".mp3", ".wav", ".flac", ".ogg" }.Contains(extension);
        }

        public static ImageFormat Format(string format)
        {
            switch (format)
            {
                case "jpg":
                    return ImageFormat.Jpeg;
                case "jpeg":
                    return ImageFormat.Jpeg;
                case "png":
                    return ImageFormat.Png;
                case "gif":
                    return ImageFormat.Gif;
                case "bmp":
                    return ImageFormat.Bmp;
                case "webp":
                    return ImageFormat.Webp;
                case "tiff":
                    return ImageFormat.Tiff;
                case "heic":
                    return ImageFormat.Heif;
                case "ico":
                    return ImageFormat.Icon;
                default:
                    return ImageFormat.Jpeg;
            }
        }

    }
}
