using System;

namespace Console.Reader.Extensions
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

        private static void ArgumentNotNull([ValidatedNotNull]object value, string name)
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
