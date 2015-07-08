using System;
using System.IO;

using StructureMap;
using StructureMap.Graph;

namespace Console.Reader.DependencyInjection
{
    public static class IoC
    {
        //  private static readonly ILog logger = LogManager.GetLogger(typeof(IoC));

        public static void Initialize()
        {
            IContainer container = new Container();
            container.Configure(
                x => x.Scan(
                    scan =>
                    {
                        scan.TheCallingAssembly();
                        scan.WithDefaultConventions();

                        string[] assemblyNames = {
                                                    "Console.Reader.Business", 
                                                    "Console.Reader.Business.UnitTest",
                                                    "Console.Reader"
                                                 };

                        foreach (var name in assemblyNames)
                        {
                            try
                            {
                                scan.Assembly(name);
                            }
                            catch (FileNotFoundException ex)
                            {
                                // logger.Warn(string.Format("Assembly not found: {0}", name), ex);
                            }
                        }
                    }
                    )
            );
        }
    }
}
