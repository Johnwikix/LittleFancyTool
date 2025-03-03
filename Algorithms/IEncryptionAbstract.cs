using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleFancyTool.Algorithms
{
    public interface IEncryptionAbstract
    {
        string Encrypt(string input, string? useUpperCase = null,int outputLength = 16,string? mode=null);
        string Decrypt(string input);
    }
}
