using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaper_2
{
    class Bai4
    {
       public static void Bai4_3()
        {
            Console.Write("Nhap N  = ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Helper.CreateArrayRamDom(arr, n);
            Helper.Display(arr);
            Console.Write("Nhap X: ");
            int x = int.Parse(Console.ReadLine());
            Stopwatch timer = new Stopwatch();
            int index;
            timer.Start();
            index = Search.SequentialSearch(arr, x);
            timer.Stop();
            Console.WriteLine($"Timer Sequential Search: {timer.ElapsedMilliseconds}ms");
            if (index == -1)
            {
                Console.WriteLine("Not Found");
            }
            else
            {
                Console.WriteLine($"A[{index}]:{arr[index]}");
            }
            timer.Restart();
            timer.Start();
            index = Array.IndexOf(arr, x);
            timer.Stop();
            Console.WriteLine($"Timer Index Of: {timer.ElapsedMilliseconds}ms");
            if (index == -1)
            {
                Console.WriteLine("Not Found");
            }
            else
            {
                Console.WriteLine($"A[{index}]:{arr[index]}");
            }
            timer.Restart();
            Sort.BubbleSort(arr);
            timer.Start();
            index = Search.BinarySearch(arr, x);
            timer.Stop();
            Console.WriteLine($"Timer Binary Search: {timer.ElapsedMilliseconds}ms");
            if (index == -1)
            {
                Console.WriteLine("Not Found");
            }
            else
            {
                Console.WriteLine($"A[{index}]:{arr[index]}");
            }
            timer.Start();
            index = Array.BinarySearch(arr, x);
            timer.Stop();
            Console.WriteLine($"Timer Binary Search Of System: {timer.ElapsedMilliseconds}ms");
            if (index == -1)
            {
                Console.WriteLine("Not Found");
            }
            else
            {
                Console.WriteLine($"A[{index}]: {arr[index]}");
            }
        }
    }
}
