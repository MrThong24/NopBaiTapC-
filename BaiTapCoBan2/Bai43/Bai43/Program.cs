using System;

namespace Bai43
{
    class Program
    {
        //Tìm số Fibonacci8 thứ n(n< 40), dùng vòng lặp(không dùng đệ quy).
        static void Main(string[] args)
        {
            int numberOfElements;
            Console.Write("Nhap vao so phan tu day Fibonacci ban muon in: ");
            numberOfElements = int.Parse(Console.ReadLine());
            Console.Write($"So Fibonacci thu {numberOfElements + 1} la: {InFibonacci(numberOfElements)}");
            Console.ReadKey();
        }
        static int InFibonacci(int num)
        {
            if (num == 0)
                return 0;
            else if (num == 1)
                return 1;
            else
                return (InFibonacci(num - 1) + InFibonacci(num - 2));
        }
    }
}
