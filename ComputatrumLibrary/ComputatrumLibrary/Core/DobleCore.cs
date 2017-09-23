using ComputatrumLibrary.Core.CoreInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputatrumLibrary.Core
{
    class DobleCore : ICore
    {
        uint coreCapacity; //integer 0 to 4294967295 --> 2 bytes(size)

        public DobleCore()
        {
            this.coreCapacity = 0;
        }

        public void AddIgnisToCoreCapacity(byte ignis)
        {
            this.coreCapacity += ignis;
        }
    }
}
