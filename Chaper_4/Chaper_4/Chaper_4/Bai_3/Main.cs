using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaper_4.Bai_3
{
    internal class Main
    {
        public Main()
        {
            DaThuc dt1 = new DaThuc(), dt2 = new DaThuc();
            while (true)
            {
                Console.Clear();
                
                Console.WriteLine("Da Thuc 1: ");
                dt1 = dt1.ToiUuDaThuc();
                dt1.print();
                Console.WriteLine("Da Thuc 2: ");
                dt2 = dt2.ToiUuDaThuc();
                dt2.print();
                Console.WriteLine("[1].Cong");
                Console.WriteLine("[2]. Tru");
                Console.WriteLine("[3]. Nhan");
                Console.WriteLine("[0]. Exit");
                Console.WriteLine("Nhap Phep Tinh");
                int option = int.Parse(Console.ReadLine());
                if (option == 0) return;
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Cong Hai Da Thuc:");
                        dt1.Cong_Hai_Da_Thuc(dt2).print();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("Tru Hai Da Thuc:");
                        dt1.Tru_Hai_Da_Thuc(dt2).print();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Nhan Hai Da Thuc:");
                        dt1.Nhan_Hai_Da_Thuc(dt2).print();
                        Console.ReadKey();
                        break;
                }

            }
           
           
            
        }
    }
}
