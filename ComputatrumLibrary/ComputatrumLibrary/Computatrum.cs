using ComputatrumLibrary.Core.CoreInterfaces;
using ComputatrumLibrary.Drive.DriveInterfaces;
using ComputatrumLibrary.Enums;
using ComputatrumLibrary.Intelligence.IntellInterfaces;
using ComputatrumLibrary.Ram.RamInterfaces;
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

        ICore Core { get; set; }
        IRam Ram { get; set; }
        IDrive Drive { get; set; }
        IIntell Intell { get; set; }

        public Computatrum ()
        {
            //this.computatrumId = todo //генерится програмно через  GUID
            this.DriveType = DriveType.HddType;
        }




    }
}
