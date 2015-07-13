using System;
using System.IO;

using StructureMap;
using StructureMap.Configuration.DSL;
using StructureMap.Graph;

namespace Console.Reader.DependencyInjection
{
    public static class IoC
    {
        public static void Initialize()
        {
            ObjectFactory.Initialize(x => x.AddRegistry(new ScanningRegistry()));
        }
    }
}