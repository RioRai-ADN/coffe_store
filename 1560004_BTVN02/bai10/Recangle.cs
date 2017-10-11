using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bai10
{
    class Recangle: Polygon, Area
    {
        public int area() { return height * width; }
        public int circuit() { return (height + width) * 2; }
    }
}
