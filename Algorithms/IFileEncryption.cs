using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleFancyTool.Algorithms
{
    public interface IFileEncryption
    {
        public Task EncryptFileAsync(string inputFilePath, string outputFilePath, string key, string iv, CancellationToken cancellationToken = default);
        public Task DecryptFileAsync(string inputFilePath, string outputFilePath, string key, string iv, CancellationToken cancellationToken = default);
    }
}
