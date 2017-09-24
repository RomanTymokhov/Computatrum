using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputatrumLibrary.Core;
using ComputatrumLibrary;
using ComputatrumLibrary.Core.CoreInterfaces;

namespace TestComputarum
{
    class Program
    {
        static void Main(string[] args)
        {
            ICore core1 = new SingleCore(23);
            Computatrum comp1 = new Computatrum(core1);
            Console.WriteLine(comp1.ComputatrumId);
        }
    }
}
