using System;

namespace Bai25
{
//    nhập vào hai số nguyên dương a, b.tính ước số chung lớn nhất và bội số
//chung nhỏ nhất của a, b.
    class Program
    {
        //Tim uoc so chung lon nhat (USCLN)
        static int USCLN(int a, int b)
        {
            if (b == 0) return a;
            return USCLN(b, a % b);
        }
        //Tim boi so chung nho nhat (BSCNN)
        static int BSCNN(int a, int b)
        {
            return (a * b) / USCLN(a, b);
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen duong a = ");
            String valA = Console.ReadLine();
            int a = Convert.ToInt32(valA);
            Console.Write("Nhap so nguyen duong b = ");
            String valB = Console.ReadLine();
            int b = Convert.ToInt32(valB);
            // tinh USCLN cua a và b
            Console.Write("USCLN cua a va b la: {0} \n", USCLN(a, b));
            // tinh BSCNN cua a và b
            Console.Write("USCLN cua cua a va b la: {0}", BSCNN(a, b));

            Console.ReadKey();
        }
    }
}
