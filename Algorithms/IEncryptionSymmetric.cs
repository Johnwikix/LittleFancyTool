﻿namespace CryptoTool.Algorithms
{
    public interface IEncryptionSymmetric
    {
        string Encrypt(
            string input,
            string? key = null,
            string? paddingMode = null,
            int keyLength = 128,
            string? iv = null,
            string? mode = null,
            string? outputType = "base64",
            string? keyIvType = "text");
        string Decrypt(
            string input,
            string? key = null,
            string? paddingMode = null,
            int keyLength = 128,
            string? iv = null,
            string? mode = null,
            string? outputType = "base64",
            string? keyIvType = "text");
    }
}
