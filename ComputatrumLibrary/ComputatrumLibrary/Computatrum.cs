using ComputatrumLibrary.Core.CoreInterfaces;
using ComputatrumLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputatrumLibrary
{
    public class Computatrum : IComputatrum
    {
        string computatrumId;

        CoreType CoreType { get; set; }
        DriveType DriveType { get; set; }

        //ICore coreq = new ICore();

        public object Core { get; private set; }
        public object Ram { get; private set; }
        public object Drive { get; private set; }
        public object Intell { get; private set; }

        public Computatrum ()
        {
            //this.computatrumId = todo //генерится програмно через  GUID
            this.DriveType = DriveType.HddType;
        }




    }
}
