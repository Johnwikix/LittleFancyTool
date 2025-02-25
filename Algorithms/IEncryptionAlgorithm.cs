using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoTool.Algorithms
{
    public interface IEncryptionAlgorithm
    {
        string Encrypt(string input, string publicKey = null, string paddingMode = null, int keyLength = 2048);
        string Decrypt(string input, string privateKey = null, string paddingMode = null, int keyLength = 2048);
    }
}
