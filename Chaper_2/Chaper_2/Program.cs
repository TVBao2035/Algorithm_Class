namespace Chaper_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = 100;
            int[] arr = new int[n];
            Helper.CreateArrayRamDom(arr, n);
            Helper.Display(arr);
            QuickSort.Run(arr, 0, n-1);
            Console.WriteLine(">>>> Sort");
            Helper.Display(arr);
          /*  while (true)
            {
                Menu();
                Console.Clear();
            }*/
        }
       

        
       
        public static void Menu()
        {
            int choose;
            do
            {
                Console.WriteLine("++++++++ MENU ++++++++");
                Console.WriteLine("[1]. Bai 1");
                Console.WriteLine("[2]. Bai 2");
                Console.WriteLine("[3]. Bai 3");
                Console.WriteLine("[4]. Bai 4");
                Console.WriteLine("[5]. Bai 5");
                Console.WriteLine("[6]. Bai 6");
                Console.WriteLine("[7]. Bai 7");
                Console.WriteLine("[]. Bai Tap Them");
                Console.Write("=> Option: ");
                choose = int.Parse(Console.ReadLine());
            } while (choose > 8 || choose < 1);

            switch (choose)
            {
                case 1:
                    Bai1.Menu_Bai_1();
                    Console.ReadLine();
                    break;
                case 2:
                    Bai2.Menu_Bai_2();
                    Console.ReadLine();
                    break;
                case 3:
                    Bai3.Menu_Bai_3();
                    Console.ReadLine();
                    break;
                case 4:
                    Bai4.Bai4_3();
                    Console.ReadLine();
                    break;
                case 5:
                    Bai5._Bai5();
                    Console.ReadLine();
                    break;
                case 6:
                    Bai6.MenuBai6();
                    Console.ReadLine();
                    break;
                case 7:
                    Bai7.Bai7_main();
                    Console.ReadLine();
                    break;
                default:
                    Bai_Tap_Them.Bai_Tap();
                    Console.ReadLine();
                    break;
            }

        }
    }
}
