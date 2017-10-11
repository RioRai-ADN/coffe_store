using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bai10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TINH DIEN TICH/CHU VI TAM GIAC va HINH CHU NHAT.");
            int selection = 1;
            while (selection != 0)
            {                
                Console.WriteLine("     MENU \n    1.HINH TAM GIAC.\n    2.HINH CHU NHAT\n    0.DONG");

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
                            Console.WriteLine("1.TINH CHU VI    2.TINH DIEN TICH");
                            int selection2 = int.Parse(Console.ReadLine());
                            if (selection2 == 1)
                            {
                                Triangle tri = new Triangle();
                                Console.Write("CANH TRAI:");
                                tri.edgeLeft = int.Parse(Console.ReadLine());

                                Console.Write("CANH PHAI:");
                                tri.edgeRight = int.Parse(Console.ReadLine());

                                Console.Write("CANH DAY:");
                                tri.width = int.Parse(Console.ReadLine());

                                Console.WriteLine("KET QUA:{0}", tri.circuit());
                            }
                            else if (selection2 == 2)
                            {
                                Triangle tri = new Triangle();
                                Console.Write("CHIEU CAO:");
                                tri.height = int.Parse(Console.ReadLine());

                                Console.Write("CANH DAY:");
                                tri.width = int.Parse(Console.ReadLine());

                                Console.WriteLine("KET QUA:{0}", tri.area());
                            }
                            else break;

                            Console.WriteLine();
                            Console.WriteLine("----------------------------");
                        } break;
                    case 2:
                        {

                            Console.WriteLine("1.TINH CHU VI    2.TINH DIEN TICH");
                            int selection2 = int.Parse(Console.ReadLine());
                            if (selection2 == 1)
                            {
                                Recangle rec = new Recangle();
                                Console.Write("CHIEU DAI:");
                                rec.width = int.Parse(Console.ReadLine());

                                Console.Write("CHIEU CAO:");
                                rec.height = int.Parse(Console.ReadLine());

                                Console.WriteLine("KET QUA:{0}", rec.circuit());
                            }
                            else if (selection2 == 2)
                            {
                                Recangle rec = new Recangle();
                                Console.Write("CHIEU DAI:");
                                rec.width = int.Parse(Console.ReadLine());

                                Console.Write("CHIEU CAO:");
                                rec.height = int.Parse(Console.ReadLine());

                                Console.WriteLine("KET QUA:{0}", rec.area());
                            }
                            else break;

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
