namespace LittleFancyTool.Algorithms
{
    public interface IEncryptionAbstract
    {
        string Encrypt(string input, string? useUpperCase = null, int outputLength = 16, string? mode = null);
        string Decrypt(string input);
    }
}
