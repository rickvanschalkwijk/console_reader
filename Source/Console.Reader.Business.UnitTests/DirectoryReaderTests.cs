using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Console.Reader.Business.Interfaces;

using NUnit.Framework;

namespace Console.Reader.Business.UnitTests
{
    [TestFixture]
    public class DirectoryReaderTests
    {
        private IDirectoryReader _directoryReader;

        [SetUp]
        public void SetUp()
        {
            _directoryReader = new DirectoryReader();
        }

        [Test]
        public void ProcessDirectory_ShouldReadAllTheFilesInADirectory_ReturnListOfFilesNotNull()
        {
            List<string> files = _directoryReader.ProcessDirectory(@"C:\projects\coaching\ConsoleReader\StaticSource");
            Assert.That(files, Is.Not.Null);
        }

        [Test]
        public void ProcessDirectory_ShouldReadAllTheFIlesInADirectory_ReturnListOfFiles()
        {
            List<string> files = _directoryReader.ProcessDirectory(@"C:\projects\coaching\ConsoleReader\StaticSource");
            Assert.That(files, Contains.Item(@"C:\projects\coaching\ConsoleReader\StaticSource\widget.js"));
        }
    }
}
