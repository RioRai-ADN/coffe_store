using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bai02
{
    class Program
    {
        static void Main(string[] args)
        {
            int selection = 1;
            while (selection != 0)
            {
                Console.WriteLine("TOA DO DIEM");
                Console.WriteLine("     MENU \n    1.Khoang cach giua 2 diem.\n    2.Kiem tra thuoc phan tu\n    0.DONG");

                Console.WriteLine("Nhap lua chon cua ban! ");
                //Kiem tra lua chon
                bool check = false;
                while (check == false)
                {
                    Console.Write("Selection:");
                    string str = Console.ReadLine();

                    if (!int.TryParse(str, out selection))
                    {
                    }
                    else
                    {
                        if (selection < 0 || selection > 2) { }
                        else
                            check = true;
                    }
                }

                switch (selection)
                {
                    case 1:
                        {
                            Diem d1 = new Diem();
                            Console.WriteLine("Nhap DIEM thu nhat");
                            d1.nhap();

                            Diem d2 = new Diem();
                            Console.WriteLine("Nhap DIEM thu hai");
                            d2.nhap();

                            Diem dis = new Diem();
                            double result = dis.distance(d1, d2);
                            Console.Write("KET QUA:{0}", result);
         
                            Console.WriteLine();
                            Console.WriteLine("----------------------------");

                        } break;
                    case 2:
                        {
                            Diem d1 = new Diem();
                            Console.WriteLine("Nhap DIEM thu nhat");
                            d1.nhap();

                            int result = d1.laGocPhanTu();
                            Console.Write("KET QUA:{0}", result);                         
                            Console.WriteLine();
                            Console.WriteLine("----------------------------");
                        } break;                   
                    case 0:
                        {
                            Console.WriteLine();
                            Console.WriteLine("----------------------------");
                        } break;
                    default: break;
                }

            }
        }
    }
}
