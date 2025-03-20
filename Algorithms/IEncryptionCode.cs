namespace LittleFancyTool.Algorithms
{
    public interface IEncryptionCode
    {
        string Encrypt(string input);
        string Decrypt(string input);
    }
}
