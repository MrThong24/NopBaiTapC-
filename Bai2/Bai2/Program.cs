﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n263;
            Console.WriteLine("Nhap vao mot so nguyen: ");
            n263 = int.Parse(Console.ReadLine());

            if (n263 == 0)
            {
                Console.WriteLine("Không");
            }
            else if (n263 == 1)
            {
                Console.WriteLine("Một");
            }
            else if (n263 == 2)
            {
                Console.WriteLine("Hai");
            }
            else if (n263 == 3)
            {
                Console.WriteLine("Ba");
            }
            else if (n263 == 4)
            {
                Console.WriteLine("Bốn");
            }
            else if (n263 == 5)
            {
                Console.WriteLine("Năm");
            }
            else if (n263 == 6)
            {
                Console.WriteLine("Sáu");
            }
            else if (n263 == 7)
            {
                Console.WriteLine("Bảy");
            }
            else if (n263 == 8)
            {
                Console.WriteLine("Tám");
            }
            else if (n263 == 9)
            {
                Console.WriteLine("Chín");
            }

            Console.ReadKey();
        }
    }
}
