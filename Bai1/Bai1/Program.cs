using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n263;
            Console.WriteLine("Nhap vao so nguyen: ");
            n263 = int.Parse(Console.ReadLine());
            if (n263 >= 0)
            {
                Console.WriteLine("Day la so nguyen duong");
            }
            else
            {
                Console.WriteLine("Day la so nguyen am");
            }
            Console.ReadKey();
        }
    }
}
