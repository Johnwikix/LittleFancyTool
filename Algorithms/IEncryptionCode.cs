using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleFancyTool.Algorithms
{
    public interface IEncryptionCode
    {
        string Encrypt(string input);
        string Decrypt(string input);
    }
}
