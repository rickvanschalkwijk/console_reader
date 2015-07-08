using NUnit.Framework;

using StructureMap;

using IContainer = StructureMap.IContainer;

namespace Console.Reader.DependencyInjection.UnitTests
{
    [TestFixture]
    public class IoCUnitTests
    {
        [Test]
        public void Initialize_ShouldInitIoC_ReturnBool()
        {
            IContainer container = new Container();
            container.AssertConfigurationIsValid();
        }
    }
}
