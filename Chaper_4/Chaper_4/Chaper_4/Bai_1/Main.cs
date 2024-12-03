using Chaper_4.Bai_1.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaper_4.Bai_1
{
    internal class Main
    {
        public Main()
        {
            int[] arr = [2, 5, 3, 3, 3 ,4, 5, 0];
            LinkedList list = new LinkedList();
            foreach (int e in arr)
            {
                Node node = new Node(e);
                list.Add(node);
            }
            list_bai_1(list);
            
        }

        public void list_bai_1(LinkedList list)
        {
            int option;
            while (true)
            {
                Console.Clear();
                do
                {
                    Console.WriteLine("+++++++++++ Bai 1 ++++++++");
                    Console.WriteLine("[1]. Bai 1.3");
                    Console.WriteLine("[2]. Bai 1.4");
                    Console.WriteLine("[3]. Bai 1.5");
                    Console.WriteLine("[4]. Bai 1.6");
                    Console.WriteLine("[5]. Bai 1.7");
                    Console.WriteLine("[6]. Bai 1.8");
                    Console.WriteLine("[7]. Bai 1.9");
                    Console.WriteLine("[8]. Bai 1.10");
                    Console.WriteLine("[9]. Bai 1.11");
                    Console.WriteLine("[10]. Bai 1.12");
                    Console.WriteLine("[11]. Bai 1.13");
                    Console.WriteLine("[12]. Bai 1.14");
                    Console.WriteLine("[13]. Bai 1.15");
                    Console.WriteLine("[14]. Bai 1.16");
                    Console.WriteLine("[15]. Bai 1.17");
                    Console.WriteLine("[16]. Bai 1.18");
                    Console.WriteLine("[0]. Exit");
                    Console.Write("Enter Option:");
                    option = int.Parse(Console.ReadLine());
                    if (option == 0) return;
                } while (option < 1 || option > 16);

                Console.Clear();
                switch (option)
                {
                    case 1:
                        new Bai_1_3(list);
                        Console.ReadLine();
                        break;
                    case 2:
                        new Bai_1_4(list);
                        Console.ReadLine();
                        break;
                    case 3:
                        new Bai_1_5(list);
                        Console.ReadLine();
                        break;
                    case 4:
                        new Bai_1_6(list);
                        Console.ReadLine();
                        break;
                    case 5:
                        new Bai_1_7(list);
                        Console.ReadLine();
                        break;
                    case 6:
                        new Bai_1_8(list);
                        Console.ReadLine();
                        break;
                    case 7:
                        new Bai_1_9(list);
                        Console.ReadLine();
                        break;
                    case 8:
                        new Bai_1_10(list);
                        Console.ReadLine();
                        break;
                    case 9:
                        new Bai_1_11(list);
                        Console.ReadLine();
                        break;
                    case 10:
                        new Bai_1_12(list);
                        Console.ReadLine();
                        break;
                    case 11:
                        new Bai_1_13(list);
                        Console.ReadLine();
                        break;
                    case 12:
                        new Bai_1_14(list);
                        Console.ReadLine();
                        break;
                    case 13:
                        new Bai_1_15(list);
                        Console.ReadLine();
                        break;
                    case 14:
                        new Bai_1_16(list);
                        Console.ReadLine();
                        break;
                    case 15:
                        new Bai_1_17(list);
                        Console.ReadLine();
                        break;
                    case 16:
                        new Bai_1_18(list);
                        Console.ReadLine();
                        break;
                }
            }
        }

    }
}
