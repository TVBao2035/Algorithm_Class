using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaper_2
{
    internal class Bai1
    {
        public static void Menu_Bai_1()
        {
            int choose;
            do
            {
                Console.WriteLine("++++++++ MENU ++++++++");
                Console.WriteLine("[1]. Bai 1.1");
                Console.WriteLine("[2]. Bai 1.2");
                Console.WriteLine("[3]. Bai 1.3");
                Console.WriteLine("[4]. Bai 1.4");
                Console.WriteLine("[5]. Bai 1.5");
                Console.WriteLine("[6]. Bai 1.6");
                Console.WriteLine("[7]. Bai 1.7");
                Console.WriteLine("[8]. Bai 1.8");
                Console.WriteLine("[9]. Bai 1.9");
                Console.WriteLine("[10]. Bai 1.10");
                Console.Write("=> Option: ");
                choose = int.Parse(Console.ReadLine());
            } while (choose > 10 || choose < 1);
            switch (choose)
            {
                case 1:
                    Bai1_1();
                    break;
                case 2:
                    Bai1_2();
                    break;
                case 3:
                    Bai1_3();
                    break;
                case 4:
                    Bai1_4();
                    break;
                case 5:
                    Bai1_5();
                    break;
                case 6:
                    Bai1_6();
                    break;
                case 7:
                    Bai1_7();
                    break;
                case 8:
                    Bai1_8();
                    break;
                case 9:
                    Bai1_9();
                    break;
                case 10:
                    Bai1_10();
                    break;

            }
        }
        public static void Bai1_1()
        {
            Console.WriteLine("BAI 1.1");
            int[] arr = new int[] { 9, 5, 3, 6, 8, 0, 2, 5, 4, 7 };
            Helper.Display(arr);
            Console.Write("Nhap X: ");
            int x = int.Parse(Console.ReadLine());
            int index = Search.Search_First_Element_Index(arr, x);
            if (index >= 0)
            {
                Console.WriteLine($"PHAN TU DAU TIEN: a[{index}] = {arr[index]}");
            }
            else
            {
                Console.WriteLine("NOT FOUND");
            }
            
        }

        public static void Bai1_2()
        {
            Console.WriteLine("BAI 1.2");
            int[] arr = new int[] { 9, 5, 3, 6, 8, 0, 2, 5, 4, 7 };
            Helper.Display(arr);
            Console.Write("Nhap X: ");
            int x = int.Parse(Console.ReadLine());
            int index = Search.Search_Last_Element_Index(arr, x);
            if(index >= 0)
            {
                Console.WriteLine($"PHAN TU CUOI CUNG: a[{index}] = {arr[index]}");

            }
            else
            {
                Console.WriteLine("NOT FOUND");
            }
        }

        public static void Bai1_3()
        {
            Console.WriteLine("BAI 1.3");
            int[] arr = new int[] { 9, 5, 3, 6, 8, 0, 2, 5, 4, 7 };
            Helper.Display(arr);
            Console.Write("Nhap X: ");
            int x = int.Parse(Console.ReadLine());
            List<int> indies = Search.Search_All_Element(arr, x);
            if(indies.Count != 0)
            {
                Console.WriteLine("DANH SACH TAT CA CAC PHAN TU:");
                foreach(int index in indies)
                {
                    Console.WriteLine($"a[{index}] = {arr[index]}");

                }
            }
            else
            {
                Console.WriteLine("NOT FOUND");
            }
        }

        public static void Bai1_4()
        {
            Console.WriteLine("BAI 1.4");
            int[] arr = new int[] { 9, 0, 5, 3, 6, 8, 0, 2, 5, 4, 7 };
            Helper.Display(arr);
            int index = Search.Search_First_Smallest_Element(arr);
            Console.WriteLine($"PHAN TU NHO NHAT DAU TIEN: a[{index}] = {arr[index]}");

        }

        public static void Bai1_5()
        {
            Console.WriteLine("BAI 1.5");
            int[] arr = new int[] { 9, 5, 3, 6, 8, 0, 2, 5, 4, 7, 9 };
            Helper.Display(arr);
            int index = Search.Search_Last_Biggest_Element(arr);
            Console.WriteLine($"PHAN TU LON NHAT DAU TIEN: a[{index}] = {arr[index]}");
        }

        public static void Bai1_6()
        {
            Console.WriteLine("BAI 1.6");
            int[] arr = new int[] {0, 9, 5, 0, 3, 6, 8, 0, 2, 5, 4, 7 };
            Helper.Display(arr);
     
            List<int> indies = Search.Search_All_Smallest_Element(arr);
            if (indies.Count != 0)
            {
                Console.WriteLine("DANH SACH TAT CA CAC PHAN TU NHO NHAT:");
                foreach (int index in indies)
                {
                    Console.WriteLine($"a[{index}] = {arr[index]}");
                }
            }
            else
            {
                Console.WriteLine("NOT FOUND");
            }
        }

        public static void Bai1_7()
        {
            Console.WriteLine("BAI 1.7");
            int[] arr = new int[] { 5, 3, 6, 8, 9, 0, 2, 5, 4, 7, 9 };
            Helper.Display(arr);
            int index = Search.Search_First_Odd_Biggest_Element(arr);
            Console.WriteLine($"PHAN TU LE LON NHAT DAU TIEN: a[{index}] = {arr[index]}");
        }

        public static void Bai1_8()
        {
            Console.WriteLine("BAI 1.8");
            int[] arr = new int[] { 8, 5, 3, 6, 8, 9, 0, 2, 5, 4, 7, 9 };
            Helper.Display(arr);
            int index = Search.Search_Last_Even_Biggest_Element(arr);
            Console.WriteLine($"PHAN TU CHAN LON NHAT DAU TIEN: a[{index}] = {arr[index]}");
        }

        public static void Bai1_9()
        {
            Console.WriteLine("BAI 1.9");
            int[] arr = new int[] { 8, 5, 3, 6, 8, 9, 0, 2, 5, 4, 7, 9 };
            Sort.BubbleSort(arr);
            Helper.Display(arr);
            Console.Write("Nhap X: ");
            int x = int.Parse(Console.ReadLine());
            int index = Search.BinarySearch(arr, x);
            if (index == -1)
            {
                Console.WriteLine("NOT FOUND");
                return;
            }
            Console.WriteLine($"PHAN TU: a[{index}] = {arr[index]}");
        }

        public static void Bai1_10()
        {
            Console.WriteLine("BAI 1.10");
            int[] arr = new int[] { 8, 5, 3, 6, 8, 9, 0, 2, 5, 4, 7, 9 };
            Sort.BubbleSort(arr);
            Helper.Display(arr);
            Console.Write("Nhap X: ");
            int x = int.Parse(Console.ReadLine());
            int index = Search._BinarySearch(arr, x, 0, arr.Length-1);
            if(index == -1)
            {
                Console.WriteLine("NOT FOUND");
                return;
            }
            Console.WriteLine($"PHAN TU: a[{index}] = {arr[index]}");
        }

    }
}
