using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometric_shapes
{
    internal class Rect : Quad{
        public override int Perimeter()
        {
            return base.Perimeter();
        }
        public int Area()
        {
            return Side1 * Side2;
        }
        public Rect() : base() { }
        public Rect(int Side1, int Side2) : base(Side1, Side2, Side1, Side2)
        {
        }
    }
}
