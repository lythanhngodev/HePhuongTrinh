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
        public float Doi(string x)
        {
            return float.Parse(x);
        }
        void gpt(float a1, float b1, float c1, float a2, float b2, float c2)
        {
            float d, dx, dy;
            d = a1 * b2 - a2 * b1;
            dx = c1 * b2 - c2 * b1;
            dy = a1 * c2 - a2 * c1;
            if (d == 0 && dx != 0 && dy != 0)
                Console.WriteLine("==> He phuong trinh VO NGHIEM!");
            if (d == 0 && dx == 0 && dy == 0)
                Console.WriteLine("==> He phuong trinh VO SO NGHIEM!");
            if (d != 0 && dx != 0 && dy != 0)
            {
                Console.WriteLine("==> Nghiem 1: " + dx/d);
                Console.WriteLine("==> Nghiem 2: " + dy/d);
            }
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
                Console.WriteLine("\t:( Nhap sai he so!"+pt._a1+" "+pt._a2);
                goto nhaplai;
            }
            //------------------------------------------------//
            //------------- Giai he phuong trinh -------------//
            //------------------------------------------------//
            else
            {
                pt._a1 = pt.Doi(pt.a1);
                pt._b1 = pt.Doi(pt.b1);
                pt._c1 = pt.Doi(pt.c1);
                pt._a2 = pt.Doi(pt.a2);
                pt._b2 = pt.Doi(pt.b2);
                pt._c2 = pt.Doi(pt.c2);
                pt.gpt(pt._a1, pt._b1, pt._c1, pt._a2, pt._b2, pt._c2);
            }
            Console.Read();
        }
    }
}
