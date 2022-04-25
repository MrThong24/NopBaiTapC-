using System;

namespace Bai19
{
    //Nhập vào thời điểm 1 và thời điểm 2. Tìm thời gian trải qua giữa hai thời điểm này tính bằng giờ, phút, giây
    class Program
    {
        static void Main(string[] args)
        {
            int h, m, s, h2, m2, s2;
            long time;
            Console.WriteLine("Nhap gio, phut, giay[1]:");
            h = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());
            s = Convert.ToInt32(Console.ReadLine());
            time = 3600 * h + 60 * m + s;
            Console.WriteLine("Nhap gio, phut, giay[2]:");
            h2 = Convert.ToInt32(Console.ReadLine());
            m2 = Convert.ToInt32(Console.ReadLine());
            s2 = Convert.ToInt32(Console.ReadLine());
            time -= 3600 * h2 + 60 * m2 + s2;
            if (time < 0) time = -time;
            Console.WriteLine("Hieu thoi gian: {0} gio, {1} phut, {2} giay",
                time / 3600, (time % 3600) / 60, (time % 3600) % 60);
            Console.ReadKey();
        }
    }
}
