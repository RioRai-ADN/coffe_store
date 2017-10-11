using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bai10
{
    class Triangle: Polygon, Area
    {
        public int edgeRight, edgeLeft;
        public int area() { return width * height / 2; }
        public int circuit() { return (edgeLeft + edgeRight + width); }
    }
}
