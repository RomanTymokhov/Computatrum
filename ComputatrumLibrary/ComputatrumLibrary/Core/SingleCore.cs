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
        ushort coreCapacity; //integer 0 to 65535 -->2 bytes(size)

        public SingleCore(byte ignis = 0)
        {
            this.coreCapacity = ignis;
        }

        //Interfaces method
        public void AddIgnisToCoreCapacity(byte ignis)
        {
            this.coreCapacity += ignis;
        }

        //Service Methods
        //private GetCoreTick
    }
}
