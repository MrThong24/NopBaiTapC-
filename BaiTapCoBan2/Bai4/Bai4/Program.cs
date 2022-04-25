using System;

namespace Bai4
{
    //Viết chương trình nhập vào ba số thực là ba cạnh của một tam giác. Kiểm tra
    //ba cạnh được nhập có hợp lệ hay không.Nếu hợp lệ, hãy cho biết loại tam giác và
    //tính diện tích tam giác đó.

    class Program
    {
        static void Main(string[] args)
        {
            double s, p;
            Console.Write("Nhap vao canh a:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhap vao canh b:");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Nhap vao canh c:");
            double c = double.Parse(Console.ReadLine());

            if (a + b < c || a + c < b || b + c < a)
            {
                //la tam giac
                Console.WriteLine("day khong phai la tam giac ");
            }
            else if (a == b && b == c)
            {
                p = (a + b + c) / 2;
                s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                //tam giac deu
                Console.WriteLine(" tam giac deu");
                Console.WriteLine("dien tich tam giac deu la: " + Math.Round(s, 4));
            }
            else if (a == b || a == c || b == c) // 2 canh bat ky bang nhau
            {
                // tam giac can
                p = (a + b + c) / 2;
                s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine("tam giac can");
                Console.WriteLine("dien tich tam giac can la: " + Math.Round(s, 4));
            }
            else if (a * a == b * b + c * c || b * b == a * a + c * c || c * c == a * a + b * b) // 2 canh bat ky bang nha
            {
                // tam vuong
                p = (a + b + c) / 2;
                s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine("tam giac vuong");
                Console.WriteLine("dien tich tam giac vuong la: " + Math.Round(s, 4));
            }
            else
            {
                p = (a + b + c) / 2;
                s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine("dien tich tam giac la: " + Math.Round(s, 4));
            }

        }
    }
}