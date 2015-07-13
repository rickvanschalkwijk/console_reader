using System.Collections.Generic;

using Console.Reader.Business.Readers;
using Console.Reader.Business.Readers.Interfaces;

using NUnit.Framework;

namespace Console.Reader.Business.UnitTests.Readers
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
            List<string> files = _directoryReader.ProcessDirectory(@"..\..\..\..\StaticSource");
            Assert.That(files, Is.Not.Null);
        }

        [Test]
        public void ProcessDirectory_ShouldReadAllTheFIlesInADirectory_ReturnListOfFiles()
        {
            List<string> files = _directoryReader.ProcessDirectory(@"..\..\..\..\StaticSource");
            Assert.That(files, Contains.Item(@"..\..\..\..\StaticSource\widget.js"));
        }
    }
}
