using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bai10
{
    class Polygon
    {
        public int height, width;

        protected int Width
        {
            get { return width; }
            set { 
                if (width > 0)
                    width = value; 
            }
        }

        protected int Height
        {
            get { return height; }
            set {
                if (height > 0)
                    height = value;
            }
        }

    }

}
