using System;

using Console.Reader.Extensions;

using NUnit.Framework;

namespace Console.Reader.UnitTests.Extensions
{
    [TestFixture]
    public class EnsureTests
    {
        private string _argumentNull = null;

        private string _argumentEmpty = string.Empty;

        private string _argument = "argument";

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ArgumentNotNullOrStringEmpty_ShouldThrowExceptionWithStringIsNull()
        {
            Ensure.ArgumentNotNullOrStringEmpty(_argumentNull, "Argument");
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void ArgumentNotNullOrStringEmpty_ShouldThrowExceptionWithStringIsEmpty()
        {
            Ensure.ArgumentNotNullOrStringEmpty(_argumentEmpty, "Argument");
        }

        [Test]
        public void ArgumentNotNullOrStringEmpty_ShouldNotThrowExceptionWhenStringIsNotEmpty()
        {
            Ensure.ArgumentNotNullOrStringEmpty(_argument, "Argument");
        }
    }
}
