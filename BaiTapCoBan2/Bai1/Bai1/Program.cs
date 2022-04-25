using System;

namespace Bai1
{   
    //Bai 1: Tinh the tich hinh cau
    class Program
    {
        static void Main(string[] args)
        {
            double V, S;
            Console.Write("Nhap dien tich S: ");
            S = Convert.ToDouble(Console.ReadLine());
            V = (4 * Math.PI / 3) * Math.Pow(Math.Sqrt(S / (4 * Math.PI)), 3);
            Console.WriteLine("The tich V: " + V);
            Console.ReadKey();
        }
    }
}
