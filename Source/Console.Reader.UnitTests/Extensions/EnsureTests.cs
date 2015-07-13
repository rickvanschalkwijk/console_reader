using System;
using System.IO;

using Console.Reader.Common.Extensions;

using NUnit.Framework;

namespace Console.Reader.UnitTests.Extensions
{
    [TestFixture]
    public class EnsureTests
    {
        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ArgumentNotNullOrStringEmpty_ShouldThrowExceptionWithStringIsNull()
        {
            Ensure.ArgumentNotNullOrStringEmpty(null, "Argument");
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void ArgumentNotNullOrStringEmpty_ShouldThrowExceptionWithStringIsEmpty()
        {
            Ensure.ArgumentNotNullOrStringEmpty(string.Empty, "Argument");
        }

        [Test]
        public void ArgumentNotNullOrStringEmpty_ShouldNotThrowExceptionWhenStringIsNotEmpty()
        {
            Ensure.ArgumentNotNullOrStringEmpty("argument", "Argument");
        }

        [Test]
        [ExpectedException(typeof(DirectoryNotFoundException))]
        public void DirectoryExists_ShouldThrowExceptionWhenDirNotExists()
        {
            Ensure.DirectoryExists("./Extension/");
        }

        [Test]
        [ExpectedException(typeof(FileNotFoundException))]
        public void FileExists_ShouldThrowExceptionWhenFileNotExists()
        {
            Ensure.FileExists("EnsurTests.cs");
        }

        [Test]
        [ExpectedException(typeof(DirectoryNotFoundException))]
        public void DirectoryExists_ShouldNotThrowException()
        {
            Ensure.DirectoryExists("./Extensions/");
        }

        [Test]
        [ExpectedException(typeof(FileNotFoundException))]
        public void FileExists_ShouldNotThrowException()
        {
            Ensure.FileExists("EnsureTests.cs");
        }
    }
}
