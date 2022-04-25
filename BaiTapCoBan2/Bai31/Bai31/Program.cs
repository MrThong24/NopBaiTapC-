using System;

namespace Bai31
{
    //Viết chương trình in bảng cửu chương từ 2 đến 9 ra màn hình
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n");
            Console.Write("In bang cuu chuong trong C#:\n");
            Console.Write("----------------------------");
            Console.Write("\n\n");
            int num, soNhan;
            num = 2;
            do
            {
                soNhan = 1;
                do
                {
                    Console.WriteLine("{0} x {1} = {2}",num, soNhan, num * soNhan);
                    soNhan++;
                }
                while (soNhan <= 10);
                Console.WriteLine();
                num++;

            } while (num <= 9);

            Console.ReadKey();
        }
    }
}
