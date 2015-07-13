using StructureMap.Configuration.DSL;
using StructureMap.Graph;

namespace Console.Reader.DependencyInjection
{
    public class ScanningRegistry : Registry
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScanningRegistry"/> class.
        /// </summary>
        public ScanningRegistry()
        {
            Scan(
                x =>
                {
                    x.TheCallingAssembly();
                    x.WithDefaultConventions();
                    x.Assembly("Console.Reader.Business");
                });
        }
    }
}