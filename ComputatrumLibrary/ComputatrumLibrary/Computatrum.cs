using ComputatrumLibrary.Core;
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
    public class Computatrum
    {
        public string ComputatrumId { get; private set; }
        public uint Ignis { get; private set; } //integer 0 to 4294967295 -->4 bytes(size)

        CoreType CoreType { get; set; }
        RamType RamType { get; set; }
        DriveType DriveType { get; set; }
        IntellType IntelType { get; set; }

        ICore Core { get; set; }
        IRam Ram { get; set; }
        IDrive Drive { get; set; }
        IIntell Intell { get; set; }

        public Computatrum ()
        {
            this.ComputatrumId = Guid.NewGuid().ToString();
            this.Ignis = 0;
            this.CoreType = CoreType.SingleCore;
            this.RamType = RamType.Simm;
            this.DriveType = DriveType.HddType;
            this.IntelType = IntellType.
        }

        public Computatrum (ICore core /*IRam ram, IDrive drive, IIntell intell*/)
        {
            this.Core = (SingleCore)core;
        }

        void CalculateIgnis(uint ignis, CalculateType calcType)
        {
            if (calcType == CalculateType.Plus && (Ignis += ignis) <= uint.MaxValue) Ignis += ignis;
            if (calcType == CalculateType.Minus && (Ignis -= ignis) >= uint.MinValue) Ignis -= ignis;
         }

    }
}
