using System.Collections.Generic;

namespace Console.Reader.Business.Interfaces
{
    public interface IDirectoryReader
    {
        List<string> ProcessDirectory(string targetDirectory);
    }
}
