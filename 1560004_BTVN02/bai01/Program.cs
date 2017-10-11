using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bai01
{
    class Program
    {
        static void Main(string[] args)
        {
            int selection = 1;
            while (selection != 0)
            {
                Console.WriteLine("TINH TOAN PHAN SO");
                Console.WriteLine("     MENU \n    1.TONG\n    2.HIEU\n    3.TICH\n    0.DONG");

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
                        if (selection < 0 || selection > 3) { }
                        else
                            check = true;
                    }
                }

                switch(selection)
                {
                    case 1: 
                        {
                            PhanSo ps1 = new PhanSo();
                            Console.WriteLine("Nhap PHAN SO thu nhat");
                            ps1.nhap();

                            PhanSo ps2 = new PhanSo();
                            Console.WriteLine("Nhap PHAN SO thu hai");
                            ps2.nhap();

                            PhanSo result = new PhanSo();
                            result = ps1 + ps2;
                            result = result.rutGonPhanSo();
                            Console.Write("KET QUA:");
                            result.xuat();
                            Console.WriteLine();
                            Console.WriteLine("----------------------------");

                        } break;
                    case 2: 
                        {
                            PhanSo ps1 = new PhanSo();
                            Console.WriteLine("Nhap PHAN SO thu nhat");
                            ps1.nhap();

                            PhanSo ps2 = new PhanSo();
                            Console.WriteLine("Nhap PHAN SO thu hai");
                            ps2.nhap();

                            PhanSo result = new PhanSo();
                            result = ps1 - ps2;
                            result = result.rutGonPhanSo();
                            Console.Write("KET QUA:");
                            result.xuat();
                            Console.WriteLine();
                            Console.WriteLine("----------------------------");
                        } break;
                    case 3:
                        {
                            PhanSo ps1 = new PhanSo();
                            Console.WriteLine("Nhap PHAN SO thu nhat");
                            ps1.nhap();

                            PhanSo ps2 = new PhanSo();
                            Console.WriteLine("Nhap PHAN SO thu hai");
                            ps2.nhap();

                            PhanSo result = new PhanSo();
                            result = ps1 * ps2;
                            result = result.rutGonPhanSo();
                            Console.Write("KET QUA:");
                            result.xuat();
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
