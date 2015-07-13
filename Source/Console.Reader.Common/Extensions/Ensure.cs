using System;
using System.IO;

namespace Console.Reader.Common.Extensions
{
    public static class Ensure
    {
        public static void ArgumentNotNullOrStringEmpty([ValidatedNotNull]string value, string name)
        {
            ArgumentNotNull(value, name);

            if (!string.IsNullOrWhiteSpace(value))
            {
                return;
            }

            throw new ArgumentException("String cannot be empty", name);
        }

        public static void DirectoryExists(string path)
        {
            if (Directory.Exists(path))
            {
                return;
            }

            throw new DirectoryNotFoundException("Directory not found");
        }

        public static void FileExists(string path)
        {
            if (File.Exists(path))
            {
                return;
            }

            throw new FileNotFoundException("File Not found");
        }

        public static void ArgumentNotNull([ValidatedNotNull]object value, string name)
        {
            if (value != null)
            {
                return;
            }

            throw new ArgumentNullException(name);
        }
    }

    internal sealed class ValidatedNotNullAttribute : Attribute
    {
    }
}
