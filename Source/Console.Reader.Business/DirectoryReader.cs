using System.Collections.Generic;
using System.IO;
using System.Linq;

using Console.Reader.Business.Interfaces;
using Console.Reader.Common.Extensions;

namespace Console.Reader.Business
{
    public class DirectoryReader : IDirectoryReader
    {
        public DirectoryReader()
        {

        }

        public List<string> ProcessDirectory(string targetDirectory)
        {
            Ensure.DirectoryExists(targetDirectory);

            List<string> files = Directory.GetFiles(targetDirectory).ToList();

            return files;
        }
    }
}
