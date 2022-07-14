using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal struct SpecialTestStruct
    {
        public double NumSide { get; set; }
        public double LengthSide { get; set; }
        public double Square { get; set; }
        public static SpecialTestStruct Inserter(SpecialTestStruct fig)
        {
            fig.Square = fig.NumSide * fig.LengthSide;
            return new SpecialTestStruct { NumSide = fig.NumSide, LengthSide = fig.LengthSide, Square = fig.Square };
        }
        public static void Overrider(ref SpecialTestStruct fig)
        {
            fig.Square = fig.NumSide * fig.LengthSide + 228;
        }
    }
}
