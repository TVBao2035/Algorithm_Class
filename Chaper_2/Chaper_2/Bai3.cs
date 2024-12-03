using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Chaper_2
{
    internal class Bai3
    {
        public static void Menu_Bai_3()
        {
            int choose;
            do
            {
                Console.WriteLine("++++++++ MENU ++++++++");
                Console.WriteLine("[1]. Bai 3.1");
                Console.WriteLine("[2]. Bai 3.2");
                Console.WriteLine("[3]. Bai 3.3");
                Console.WriteLine("[4]. Bai 3.4");
                Console.WriteLine("[5]. Bai 3.5");
                Console.WriteLine("[6]. Bai 3.6");
                Console.WriteLine("[7]. Bai 3.7");
                Console.WriteLine("[8]. Bai 3.8");
                Console.Write("=> Option: ");
                choose = int.Parse(Console.ReadLine());
            } while (choose > 8 || choose < 1);
            int[] array = { 2, 4, 8, 9, 1, 3, 5, 6, 7, 0 };
            Console.WriteLine(choose);
            switch (choose)
            {
                case 1:
                    Bai3_1(array);
                    break;
                case 2:
                    Bai3_2(array);
                    break;
                case 3:
                    Bai3_3(array);
                    break;
                case 4:
                    Bai3_4(array);
                    break;
                case 5:
                    Bai3_5(array);
                    break;
                case 6:
                    Bai3_6(array);
                    break;
                case 7:
                    Bai3_7(array, 0, array.Length - 1);
                    break;
                case 8:
                    Bai3_8();
                    Console.ReadLine();
                    break;


            }
        }

        public static void Bai3_1(int[] array)
        {
            Console.WriteLine("Bai 3.1:");
            int n = array.Length;
            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                    Helper.DisplayArray(array, i + 1);
                }
                Console.WriteLine("+++++++++++++++++++");
            }
        }

        public static void Bai3_2(int[] arr)
        {
            Console.WriteLine("Bai 3.2:");

            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = n - 1; j > i; j--)
                {
                    if (arr[j] > arr[j - 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = temp;
                    }
                    Helper.DisplayArray(arr, n - i);
                }
                Console.WriteLine("+++++++++++++++++++");
            }
        }

        public static void Bai3_3(int[] arr)
        {
            Console.WriteLine("Bai 3.3:");

            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[minIndex] > arr[j])
                    {
                        minIndex = j;
                    }
                }
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
        }

        public static void Bai3_4(int[] arr)
        {
            Console.WriteLine("Bai 3.4:");

            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[minIndex] < arr[j])
                    {
                        minIndex = j;
                    }
                }
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
        }

        public static void Bai3_5(int[] arr)
        {
            Console.WriteLine("Bai 3.5:");

            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int x = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > x)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = x;
            }
            Helper.Display(arr);
        }

        public static void Bai3_6(int[] arr)
        {
            Console.WriteLine("Bai 3.6:");

            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int x = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] < x)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = x;
            }
            Helper.Display(arr);
        }

        public static void Bai3_7(int[] arr, int left, int right)
        {
            int i = left;
            int j = right;
            int mid = (right + left) / 2;
            int x = arr[mid];

            while (i < j)
            {
                while (arr[i] < x)
                {
                    i++;
                }
                while (arr[j] > x)
                {
                    j--;
                }

                if (i <= j)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                    j--;
                }
            }

            if (left < j)
            {
                Bai3_7(arr, left, j);
            }

            if (right > i)
            {
                Bai3_7(arr, i, right);
            }
        }

        public static void Bai3_8()
        {
            Console.Write("Nhap N = ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            Helper.CreateArrayRamDom(arr, arr.Length);

            Helper.Display(arr);

            QuickSort(arr, 0, arr.Length - 1);
            Helper.Display(arr);



        }

        public static int Partition(int[] arr, int left, int right)
        {
            int mid = (right - left) / 2;
            int save = arr[mid];
            while (left < right)
            {
                while (arr[left] < save) left++;

                while (arr[right] > save) right--;

                if (left <= right)
                {
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                    left++;
                    right--;
                }
            }

            return left;
        }

        public static void QuickSort(int[] arr, int left, int right)
        {
            if (left <= right)
            {
                int pivotIndex = Partition(arr, left, right);

                QuickSort(arr, left, pivotIndex - 1);
                QuickSort(arr, pivotIndex + 1, right);
            }
        }


    }
}
