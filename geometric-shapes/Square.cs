using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometric_shapes
{
    internal class Square : Rect
    {

        public int Perimeter()
        {
            return base.Perimeter();
        }
        public int Area()
        {
            return base.Area();
        }
        public Square() : base() { }
        public Square(int side) : base(side, side) // this is borrowing from the base class which is the rectangle. 
        {
        }
    }
}
