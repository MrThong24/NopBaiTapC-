using System;

namespace Bai6
{
    //Viết chương trình nhập vào ba số nguyên.Hãy in ba số này ra màn hình theo thứ tự tăng dần và chỉ dùng tối đa một biến phụ.
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, t;
            Console.Write("Nhap a, b, c: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            if (a < b)
            {
                t = a;
                a = b;
                b = t;
            }
            if (a < c)
            {
                t = a;
                a = c;
                c = t;
            }
            if (b < c)
            {
                t = b;
                b = c;
                c = t;
            }
            Console.WriteLine($"Tang dan: {c} {b} {a}");
            Console.ReadKey();
        }
    }
}
