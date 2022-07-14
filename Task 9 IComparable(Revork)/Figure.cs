using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6_IComparable
{
    internal class Figure : IComparable<Figure>
    {
        private IComparable<Figure> _comparableImplementation;
        public double Side { get; }
        public double Square { get; set; }
        public Figure(double side)
        {
            Side = side;
            Square = Side * Side;
        }
        public int CompareTo(Figure? other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;
            if (Square.CompareTo(other.Square) > 0) return -1;
            if (Side.CompareTo(other.Side) > 0) return -1;
            return 1;
        }
    }
}
