using System.Collections.Generic;
using System.IO;

using Console.Reader.Business.Readers.Interfaces;

namespace Console.Reader.Business.Readers
{
    public class FileReader : IFileReader
    {
        public void ProcessFiles(IEnumerable<string> filepaths)
        {
            foreach (string filepath in filepaths)
            {
                string extension = Path.GetExtension(filepath);
                switch (extension)
                {
                    case ".json":

                        break;
                    case ".csv":

                        break;
                    default:
                        System.Console.WriteLine("Can't process file with extension {0}", extension);
                        break;
                }
            }
        }
    }
}
