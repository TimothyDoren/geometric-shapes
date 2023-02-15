using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometric_shapes
{
    internal class Rect
    {
        public int LongSide { get; set; }
        public int ShortSide { get; set; }

        public int Perimeter()
        {
            return (2 * LongSide) + (2 * ShortSide);
        }
        public int Area()
        {
            return LongSide * ShortSide;
        }
        public Rect() { }
        public Rect(int longSide, int shortSide)
        {
            LongSide = longSide;
            ShortSide = shortSide;
        }
    }
}
