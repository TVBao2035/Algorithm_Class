using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaper_2
{
    internal class Bai5
    {
        public static void _Bai5()
        {
            Console.Write("Nhap N  = ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Helper.CreateArrayRamDom(arr, n);
            Helper.Display(arr);
            Stopwatch timer = new Stopwatch();

            Console.WriteLine("Bubble Sort:");
            timer.Start();
            Sort.BubbleSort(arr);
            timer.Stop();
            Console.WriteLine($"Time Of Bubble Sort: {timer.ElapsedMilliseconds}ms");

            timer.Restart();
            Helper.CreateArrayRamDom(arr, n);
            Console.WriteLine("Insert Sort:");
            timer.Start();
            Sort.InsertSort(arr);
            timer.Stop();
            Console.WriteLine($"Time Of Insert Sort: {timer.ElapsedMilliseconds}ms");

            timer.Restart();
            Helper.CreateArrayRamDom(arr, n);
            Console.WriteLine("Selection Sort:");
            timer.Start();
            Sort.SelectionSort(arr);
            timer.Stop();
            Console.WriteLine($"Time Of Selection Sort: {timer.ElapsedMilliseconds}ms");

            timer.Restart();
            Helper.CreateArrayRamDom(arr, n);
            Console.WriteLine("Quick Sort:");
            timer.Start();
            Sort.QuickSort(arr, 0, arr.Length-1);
            timer.Stop();
            Console.WriteLine($"Time Of Quick Sort: {timer.ElapsedMilliseconds}ms");

            Helper.Display(arr);


        }
    }
}
