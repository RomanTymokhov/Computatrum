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
        CoreType CoreType { get; set; }
        DriveType DriveType { get; set; }
    }
}
