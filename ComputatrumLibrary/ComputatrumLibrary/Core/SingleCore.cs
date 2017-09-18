using ComputatrumLibrary.Core.CoreInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputatrumLibrary.Core
{
    public class SingleCore : ICore
    {
        public ushort coreCapacity;

        public SingleCore(byte ignis = 0)
        {
            this.coreCapacity = ignis;
        }

        public void AddIgnisToCoreCapacity(byte ignis)
        {
            this.coreCapacity += ignis;
        }
    }
}
