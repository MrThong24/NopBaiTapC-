using System;

namespace Bai27
{
    class Program
    {
        //Nhập vào một số nguyên dương n, phân tích n thành các thừa số nguyên tố.
        static void phanTichSoNguyen(int n)
        {
            int i = 2;
            int dem = 0;
            int[] a = new int[100];
            while (n > 1)
            {
                if (n % i == 0)
                {
                    n = n / i;
                    a[dem++] = i;
                }
                else
                {
                    i++;
                }
            }
            if (dem == 0)
            {
                a[dem++] = n;
            }
            for (i = 0; i < dem - 1; i++)
            {
                Console.Write("{0} * ", a[i]);
            }
            Console.Write("{0}", a[dem - 1]);
        }


        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap so nguyen duong n = ");
            n = Convert.ToInt32(Console.ReadLine());
            phanTichSoNguyen(n);
            Console.ReadKey();
        }
    }
}
