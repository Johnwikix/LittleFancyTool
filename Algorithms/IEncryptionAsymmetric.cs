﻿namespace LittleFancyTool.Algorithms
{
    public interface IEncryptionAsymmetric
    {
        string Encrypt(string input, string? publicKey = null, string? paddingMode = null, int keyLength = 2048);
        string Decrypt(string input, string? privateKey = null, string? paddingMode = null, int keyLength = 2048);

        (string publicKey, string privateKey) GenerateKeyPair(int keyLength = 2048, string keyFormat = "PKCS#8");

        Task EncryptFileAsync(string inputFilePath, string outputFilePath, string publicKey, int keyLength);

        Task DecryptFileAsync(string inputFilePath, string outputFilePath, string privateKey, int keyLength);


    }
}
