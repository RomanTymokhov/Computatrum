using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputatrumLibrary.Core;

namespace TestComputarum
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleCore core1 = new SingleCore(122);
            Console.WriteLine(core1.coreCapacity);
            core1.AddIgnisToCoreCapacity(100);
            Console.WriteLine(core1.coreCapacity);
        }
    }
}
