using System;
using System.IO;

namespace Console.Reader.Common.Extensions
{
    public static class File
    {
        public static string GetName(string path)
        {
            try
            {
                return Path.GetFileName(path);
            }
            catch (ArgumentException ex)
            {
                return string.Format("File not found, {0}", ex);
            }
        }

        public static string GetExtension(string path)
        {
            try
            {
                return Path.GetExtension(path);
            }
            catch (ArgumentException ex)
            {
                return string.Format("File not found, {0}", ex);
            }
        }
    }
}
