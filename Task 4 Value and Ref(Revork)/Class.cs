using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class SpecialTestClass
    {
        public double NumSide { get; set; }
        public double LengthSide { get; set; }
        public double Square { get; set; }
        public static SpecialTestClass Inserter(SpecialTestClass fig)
        {
            fig.Square = fig.NumSide * fig.LengthSide;
            return new SpecialTestClass { NumSide = fig.NumSide, LengthSide = fig.LengthSide, Square = fig.Square };
        }
        public static void Overrider(ref SpecialTestClass fig)
        {
            fig.Square = fig.NumSide * fig.LengthSide + 228;

        }
    }
}
