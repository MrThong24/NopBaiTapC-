using System;

namespace Bai2
{
    //Nhập vào tọa độ 2 điểm A(xA, yA) và B(xB, yB). Tính khoảng cách AB.
    class Program
    {
        static void Main(string[] args)
        {
            double xA, xB, yA, yB;
            double AB = 0;

            Console.Write("A(xA, yA)? ");
            xA = Convert.ToDouble(Console.ReadLine());
            yA = Convert.ToDouble(Console.ReadLine());

            Console.Write("B(xB, yB)? ");
            xB = Convert.ToDouble(Console.ReadLine());
            yB = Convert.ToDouble(Console.ReadLine());

            AB = Math.Sqrt(Math.Pow((xB - xA), 2) + Math.Pow((yB - yA), 2));

            Console.WriteLine("|AB| = " + Math.Abs(AB));
            Console.ReadKey();
        }
    }
}
