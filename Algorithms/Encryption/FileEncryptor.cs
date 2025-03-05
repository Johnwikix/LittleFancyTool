using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LittleFancyTool.Algorithms.Encryption
{
    public class FileEncryptor:IFileEncryption
    {
        private const int BufferSize = 1024 * 1024; // 1MB 缓冲区大小
        public async Task EncryptFileAsync(string inputFilePath, string outputFilePath, string key, string iv, CancellationToken cancellationToken = default)
        {
            using (FileStream inputStream = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read))
            using (FileStream outputStream = new FileStream(outputFilePath, FileMode.Create, FileAccess.Write))
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(key);
                aesAlg.IV = Encoding.UTF8.GetBytes(iv);

                using (ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV))
                using (CryptoStream cryptoStream = new CryptoStream(outputStream, encryptor, CryptoStreamMode.Write))
                {
                    byte[] buffer = new byte[BufferSize];
                    int bytesRead;
                    while ((bytesRead = await inputStream.ReadAsync(buffer, 0, buffer.Length, cancellationToken)) > 0)
                    {
                        await cryptoStream.WriteAsync(buffer, 0, bytesRead, cancellationToken);
                    }
                    await cryptoStream.FlushFinalBlockAsync(cancellationToken);
                }
            }
        }

        public async Task DecryptFileAsync(string inputFilePath, string outputFilePath, string key, string iv, CancellationToken cancellationToken = default)
        {
            using (FileStream inputStream = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read))
            using (FileStream outputStream = new FileStream(outputFilePath, FileMode.Create, FileAccess.Write))
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(key);
                aesAlg.IV = Encoding.UTF8.GetBytes(iv);

                using (ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV))
                using (CryptoStream cryptoStream = new CryptoStream(inputStream, decryptor, CryptoStreamMode.Read))
                {
                    byte[] buffer = new byte[BufferSize];
                    int bytesRead;
                    while ((bytesRead = await cryptoStream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                    {
                        await outputStream.WriteAsync(buffer, 0, bytesRead, cancellationToken);
                    }
                }
            }
        }
    }
}
