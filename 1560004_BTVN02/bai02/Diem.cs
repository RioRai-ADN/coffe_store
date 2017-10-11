using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bai02
{
    class Diem
    {
        //attribute
        private int x, y;

        //constructor
        public Diem() { x = 0; y = 0; }
        ~Diem() { }

        //getter
        public int getX() { return this.x; }
        public int getY() { return this.y; }

        //function overloading
        public void nhap()
        {
            bool check = false;
            while (check == false)
            {
                Console.Write("X:");
                string str = Console.ReadLine();

                if (!int.TryParse(str, out x))
                {
                    Console.WriteLine("X la 1 so NGUYEN. Hay nhap lai!");
                }
                else
                {
                    check = true;
                }
            }

            //Nhap va kiem tra tu so
            check = false;
            while (check == false)
            {
                Console.Write("Y:");
                string str = Console.ReadLine();

                if (!int.TryParse(str, out y))
                {
                    Console.WriteLine("Y la 1 so NGUYEN. Hay nhap lai!");
                }
                else
                {
                    check = true;
                }

            }

        }

        public void xuat()
        {
            Console.Write("Point({0},{1})", this.x, this.y);
        }

        public double distance(Diem p1, Diem p2)
        {
            double result;
            result = Math.Sqrt(Math.Pow(p1.x - p2.x, 2) + Math.Sqrt(Math.Pow(p1.y + p2.y, 2)) );
            return result;
        }

        public int laGocPhanTu()
        {
            if (x > 0 && y > 0)
                return 1;
            if (x > 0 && y < 0)
                return 4;
            if (x < 0 && y > 0)
                return 2;
            if (x < 0 && y < 0)
                return 3;
            else return 0; // la tam toa do
        }

    }//end
}
