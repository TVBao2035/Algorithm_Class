
using Chaper_4.Bai_1;
using Chaper_4.Bai_1.Setup;
using Chaper_4.Bai_2;

namespace Chaper_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int option;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Bai Tap Chuong 4 +++++++++++ [ TRUONG VAN BAO == 02210112 ] => Hello Aliens");
                Console.WriteLine("[1]. Bai 1");
                Console.WriteLine("[2]. Bai 2");
                Console.WriteLine("[3]. Bai 3");
                Console.WriteLine("[0]. Thoat");
                Console.Write("Nhap Lua Chon: ");
                option = int.Parse(Console.ReadLine());
                if (option == 0) return;
                switch (option)
                {
                    case 1:
                        new Bai_1.Main();
                        break;
                    case 2:
                        new Bai_2.Main();
                        break;
                    case 3:
                        new Bai_3.Main();
                        break;
                }
            }
        }
    }
}
