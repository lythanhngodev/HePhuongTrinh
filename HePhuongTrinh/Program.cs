using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HePhuongTrinh
{
    public class PhuongTrinh
    {
        public bool BatLoi(string x)
        {
            try
            {
                float a = float.Parse(x);
            }
            catch
            {
                return false;
            }
            return true;
        }
        public float DoiChuSangSo(string x)
        {
            return float.Parse(x);
        }
        public string gpt(float a1, float b1, float c1, float a2, float b2, float c2)
        {
            string ketqua = null;
            float D, Dx, Dy;
            if ((a1 * a1) + (b1 * b1) != 0 && (a2 * a2) + (b2 * b2) != 0)
            {
                D = a1 * b2 - a2 * b1;
                Dx = c1 * b2 - c2 * b1;
                Dy = a1 * c2 - a2 * c1;
                if (D != 0) ketqua = "Nghiem 1: " + Dx / D + " | Nghiem 2: " + Dy / D; ;
                if (D == 0)
                {
                    if (Dx != 0 && Dy != 0) ketqua = "VO NGHIEM";
                    else if (Dx == 0 && Dy == 0) ketqua = "VO SO NGHIEM";
                }
            }
            else
            {
                ketqua = "VO NGHIEM";
            }
            return ketqua;
        }
        string a1, b1, c1, a2, b2, c2;
        float _a1, _b1, _c1, _a2, _b2, _c2;
        static void Main(string[] args)
        {
            PhuongTrinh pt = new PhuongTrinh();
            nhaplai:
            Console.Write(" - Nhap he so a1: ");
            pt.a1 = Console.ReadLine();
            Console.Write(" - Nhap he so b1: ");
            pt.b1 = Console.ReadLine();
            Console.Write(" - Nhap he so c1: ");
            pt.c1 = Console.ReadLine();
            Console.Write(" - Nhap he so a2: ");
            pt.a2 = Console.ReadLine();
            Console.Write(" - Nhap he so b2: ");
            pt.b2 = Console.ReadLine();
            Console.Write(" - Nhap he so c2: ");
            pt.c2 = Console.ReadLine();
              //------------------------------------------------//
             //----- Kiem tra co nhap sai he so hay khong -----//
            //------------------------------------------------//
            if (!pt.BatLoi(pt.a1)||!pt.BatLoi(pt.b1)||!pt.BatLoi(pt.c1)||!pt.BatLoi(pt.a2)||!pt.BatLoi(pt.b2)||!pt.BatLoi(pt.c2))
            {
                Console.WriteLine("\t:( Nhap sai he so!");
                goto nhaplai;
            }
            //------------------------------------------------//
            //------------- Giai he phuong trinh -------------//
            //------------------------------------------------//
            else
            {
                pt._a1 = pt.DoiChuSangSo(pt.a1);
                pt._b1 = pt.DoiChuSangSo(pt.b1);
                pt._c1 = pt.DoiChuSangSo(pt.c1);
                pt._a2 = pt.DoiChuSangSo(pt.a2);
                pt._b2 = pt.DoiChuSangSo(pt.b2);
                pt._c2 = pt.DoiChuSangSo(pt.c2);
                Console.WriteLine("Nghiem phuong trinh: "+pt.gpt(pt._a1, pt._b1, pt._c1, pt._a2, pt._b2, pt._c2));
            }
            Console.Read();
        }
    }
}
