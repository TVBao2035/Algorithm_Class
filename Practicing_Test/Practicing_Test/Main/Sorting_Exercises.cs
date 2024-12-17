using Practicing_Test.Sorting_Algorithm;
using Sorting_Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicing_Test.Main
{
    internal class Sorting_Exercises
    {
        public static void Run()
        {
            int[] array = { 20, 1, 2, 6, 3, 11, 12, 19, 17, 4, 8, 10, 18, 5, 13, 14, 7, 9, 15, 16 };

            Console.WriteLine("Current Array");
            Helpers.PrintArray(array);
            //Sort.BubbleSort(array);
            //Sort.SelectionSort(array);
            //Sort.InsertionSort(array);
            //Sort.QuickSort(array);
            Sort.HeapSort(array);
        }
    }
}
