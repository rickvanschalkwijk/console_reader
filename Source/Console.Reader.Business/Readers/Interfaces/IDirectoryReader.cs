using System.Collections.Generic;

namespace Console.Reader.Business.Readers.Interfaces
{
    public interface IDirectoryReader
    {
        List<string> ProcessDirectory(string targetDirectory);

        int CountFilesInDirectory(string targetDirectory);
    }
}
