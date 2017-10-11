using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bai01
{
    class PhanSo
    {
        private float _tu;
        private float _mau;

        protected float Tu
        {
            get { return _tu; }
            set { _tu = value; }
        }
        protected float Mau
        {
            get { return _mau; }
            set
            {
                if (value != 0 )
                  _mau = value;
            }
        }

        //constructor
        public PhanSo() { _tu = 0; _mau = 0; }
        ~PhanSo() { }

        //function
        public void nhap()
        {
            //Nhap va kiem tra tu so
            bool check = false;
            while ( check == false )
            {
                Console.Write("Nhap TU:");
                string str = Console.ReadLine();

                if (!float.TryParse(str, out _tu))
                {
                    Console.WriteLine("TU SO la 1 so thuc. Hay nhap lai!");
                }
                else
                {
                    check = true;
                }
            }

            //Nhap va kiem tra mau so
            check = false;
            while (check == false)
            {
                Console.Write("Nhap MAU:");
                string str = Console.ReadLine();

                if (!float.TryParse(str, out _mau))
                {
                    Console.WriteLine("MAU SO la 1 so thuc. Hay nhap lai!");
                }
                else
                {
                    if (_mau == 0)
                        Console.WriteLine("MAU SO phai khac 0!");
                    else
                        check = true;
                }

            }

        }

        public void xuat()
        {
            Console.Write("{0}/{1}", _tu, _mau);
        }

        public float UCLN(float a, float b)
        {
            a = Math.Abs(_tu);
            b = Math.Abs(_mau);
            while (a != b && b != 0 && a != 0)
            {
                if (a > b) a = a - b;
                else b = b - a;
            }
            return a;
        }

        //Ham rut gon ps, tra ve 1 phan so moi
        public PhanSo rutGonPhanSo()
        {
            PhanSo result = new PhanSo();
            float uocChung = UCLN(_tu, _mau);

            if (uocChung != 0)
            {
                result._tu = (_tu / uocChung);
                result._mau = (_mau / uocChung);
            }
            else
            {
                result._tu = _tu;
                result._mau = _mau;
            }
            return result;
        }

        //Operator overloading: TONG, HIEU, TICH
        public static PhanSo operator + (PhanSo val1, PhanSo val2)
        {
            PhanSo result = new PhanSo();
            result._tu = (val1._tu * val2._mau) + (val2._tu * val1._mau);
            result._mau = val1._mau * val2._mau;
            return result;
        }

        public static PhanSo operator - (PhanSo val1, PhanSo val2)
        {
            PhanSo result = new PhanSo();
            result._tu = (val1._tu * val2._mau) - (val2._tu * val1._mau);
            result._mau = val1._mau * val2._mau;
            return result;
        }

        public static PhanSo operator * (PhanSo val1, PhanSo val2)
        {
            PhanSo result = new PhanSo();
            result._tu = val1._tu * val2._tu;
            result._mau = val1._mau * val2._mau;
            return result;
        }

    }
}
