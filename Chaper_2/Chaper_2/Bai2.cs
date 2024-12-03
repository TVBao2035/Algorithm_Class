using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaper_2
{
    internal class Bai2
    {
        public static void Menu_Bai_2()
        {
            int choose;
            do
            {
                Console.WriteLine("++++++++ MENU ++++++++");
                Console.WriteLine("[1]. Bai 2.1");
                Console.WriteLine("[2]. Bai 2.2");
                Console.WriteLine("[3]. Bai 2.4");
                Console.Write("=> Option: ");
                choose = int.Parse(Console.ReadLine());
            } while (choose > 3 || choose < 1);
            switch (choose)
            {
                case 1:
                    int[] array1 = { 2, 4, 8, 9, 1, 3, 5, 6, 7, 0 };
                    Bai2_1(array1, array1.Length);
                    break;
                case 2:
                    int[] array = { 2, 4, 8, 9, 1, 3, 5, 6, 7, 0 };
                    Bai2_2(array, array.Length);
                    break;
                case 3:
                    Bai2_4();
                    break;

            }
        }

        public static void Bai2_1(int[] array, int n)
        {
            Console.WriteLine("BAI 2.1");
          

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap Phan Tu A[{i}] = ");
                array[i] = int.Parse(Console.ReadLine());
            }
            Helper.Display(array);
        }

        public static void Bai2_2(int[] array, int n)
        {
            Console.WriteLine("BAI 2.2");
       
            Random rd = new Random();
            for(int i=0; i<n; i++)
            {
                int value = rd.Next(1,1000);
                Console.WriteLine($"A[{i}] = {value}");
                array[i] = value;
            }
            Helper.Display(array);
        }

        public static void Bai2_4()
        {
            Console.Write("Nhap so luong phan tu: ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            int x, index;
            Bai2_1(array, n);
            Console.Write("Nhap X: ");
            x = int.Parse(Console.ReadLine());
            Sort.QuickSort(array, 0, n - 1);
            index = Search.BinarySearch(array, x);

            if(index == -1)
            {
                Console.WriteLine("NOT FOUND");
            }
            else
            {
                Console.WriteLine($"A[{index}] = {array[index]}");
            }


            Console.Write("Nhap so luong phan tu: ");
            n = int.Parse(Console.ReadLine());
            array = new int[n];
            Bai2_2(array, n);
            Console.Write("Nhap X: ");
            x = int.Parse(Console.ReadLine());
            Sort.QuickSort(array, 0, n - 1);
            index = Search.BinarySearch(array, x);
            if (index == -1)
            {
                Console.WriteLine("NOT FOUND");
            }
            else
            {
                Console.WriteLine($"A[{index}] = {array[index]}");
            }
        }

    }
}
