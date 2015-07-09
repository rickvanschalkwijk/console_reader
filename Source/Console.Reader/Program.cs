using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Console.Reader.DependencyInjection;

namespace ConsoleReader
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // init structure map
            IoC.Initialize();
        }
    }
}
