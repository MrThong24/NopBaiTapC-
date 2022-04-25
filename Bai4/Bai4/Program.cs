using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a263, b263, c263;
            Console.WriteLine("Nhap vao 3 canh: ");
            a263 = Double.Parse(Console.ReadLine());
            b263 = Double.Parse(Console.ReadLine());
            c263 = Double.Parse(Console.ReadLine());

            if (a263 * a263 + b263 * b263 == c263 * c263 || a263 * a263 + c263 * c263 == b263 * b263 || b263 * b263 + c263 * c263 == a263 * a263)
            {
                Console.WriteLine("La 3 canh cua tam giac vuong");
            }
            else
            {
                Console.WriteLine("Khong phai la 3 canh cua tam giac vuong");
            }

            Console.ReadKey();
        }
    }
}
