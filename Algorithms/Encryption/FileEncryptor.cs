using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LittleFancyTool.Algorithms.Encryption
{
    public class FileEncryptor
    {
        private const int BufferSize = 1024 * 1024; // 1MB 缓冲区大小
        private const int BlockSize = 16; // AES 块大小

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

        public async Task DecryptFileAsync(string inputFilePath, string outputFilePath, string key, string iv, CancellationToken cancellationToken = default) {
            using (FileStream inputStream = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read))
            using (FileStream outputStream = new FileStream(outputFilePath, FileMode.Create, FileAccess.Write))
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(key);
                aesAlg.IV = Encoding.UTF8.GetBytes(iv);

                using (ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV))
                using (CryptoStream cryptoStream = new CryptoStream(inputStream, decryptor, CryptoStreamMode.Read))
                {
                    byte[] buffer = new byte[1024 * 1024]; // 1MB 缓冲区
                    int bytesRead;
                    while ((bytesRead = await cryptoStream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                    {
                        await outputStream.WriteAsync(buffer, 0, bytesRead, cancellationToken);
                    }
                }
            }
        }
      

        public async Task EncryptLargeFileAsync(string inputFilePath, string outputFilePath, byte[] key, byte[] iv, int numThreads, CancellationToken cancellationToken = default)
        {
            using (FileStream inputStream = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read))
            using (FileStream outputStream = new FileStream(outputFilePath, FileMode.Create, FileAccess.Write))
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = iv;

                long fileLength = inputStream.Length;
                long blockSize = fileLength / numThreads;

                Task[] tasks = new Task[numThreads];
                for (int i = 0; i < numThreads; i++)
                {
                    long startPosition = i * blockSize;
                    long endPosition = (i == numThreads - 1) ? fileLength : (i + 1) * blockSize;

                    tasks[i] = Task.Run(() => EncryptBlock(inputStream, outputStream, aesAlg, startPosition, endPosition, cancellationToken), cancellationToken);
                }

                await Task.WhenAll(tasks);
            }
        }

        private void EncryptBlock(FileStream inputStream, FileStream outputStream, Aes aesAlg, long startPosition, long endPosition, CancellationToken cancellationToken)
        {
            lock (inputStream)
            {
                inputStream.Seek(startPosition, SeekOrigin.Begin);
            }

            using (ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV))
            using (MemoryStream memoryStream = new MemoryStream())
            using (CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
            {
                byte[] buffer = new byte[BufferSize];
                long remainingBytes = endPosition - startPosition;
                while (remainingBytes > 0 && !cancellationToken.IsCancellationRequested)
                {
                    int bytesToRead = (int)Math.Min(remainingBytes, BufferSize);
                    int bytesRead;
                    lock (inputStream)
                    {
                        bytesRead = inputStream.Read(buffer, 0, bytesToRead);
                    }
                    if (bytesRead > 0)
                    {
                        cryptoStream.Write(buffer, 0, bytesRead);
                        remainingBytes -= bytesRead;
                    }
                }

                cryptoStream.FlushFinalBlock();

                lock (outputStream)
                {
                    outputStream.Seek(startPosition, SeekOrigin.Begin);
                    outputStream.Write(memoryStream.ToArray(), 0, (int)memoryStream.Length);
                }
            }
        }
    }
}
