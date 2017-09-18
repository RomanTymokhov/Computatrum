using ComputatrumLibrary.Core.CoreInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputatrumLibrary.Core
{
    class MultiCore : ICore
    {
        uint coreCapacity;

        public MultiCore()
        {
            this.coreCapacity = 0;
        }

        public void AddIgnisToCoreCapacity(byte ignis)
        {
            this.coreCapacity += ignis;
        }
    }
}
