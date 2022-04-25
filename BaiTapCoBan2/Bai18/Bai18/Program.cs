using System;

namespace Bai18
{
    //Viết chương trình nhập vào số giờ, xuất ra số tương đương tính theo tuần, theo ngày và theo giờ
    class Program
    {
        static void Main(string[] args)
        {
            int w, d, h;
            Console.WriteLine("Nhap vao so gio: ");
            h = int.Parse(Console.ReadLine());
            w = h / (24 * 7);
            d = (h % (24 * 7)) / 24;
            h = (h % (24 * 7)) % 24;
            Console.WriteLine( w + ":tuan "  + d + ":ngay " + h + ":gio");
        }
    }
}
