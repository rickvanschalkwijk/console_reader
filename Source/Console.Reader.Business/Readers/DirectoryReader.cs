using System.Collections.Generic;
using System.IO;
using System.Linq;

using Console.Reader.Business.Readers.Interfaces;
using Console.Reader.Common.Extensions;

namespace Console.Reader.Business.Readers
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

        public int CountFilesInDirectory(string targetDirectory)
        {
            List<string> processDirectory = ProcessDirectory(targetDirectory);

            return processDirectory.Count();
        }
    }
}
