using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a263, b263, c263;
            Console.WriteLine("Nhap ba canh: ");
            a263 = Double.Parse(Console.ReadLine());
            b263 = Double.Parse(Console.ReadLine());
            c263 = Double.Parse(Console.ReadLine());

            if (a263 + b263 > c263 && b263 + c263 > a263 && a263 + c263 > b263)
            {
                Console.WriteLine("La ba canh cua tam giac");
            }
            else
            {
                Console.WriteLine("Khong phai ba canh cua tam giac");
            }

            Console.ReadKey();
        }   
    }
}
