using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sorting_Algorithms.Sorts;

namespace Practicing_Test.Sorting_Algorithm
{
    internal class Sort
    {
        public static void BubbleSort(int[] array)
        {
            BubbleSort bubbleSort = new BubbleSort(array);
            bubbleSort.Sort();
        }

        public static void SelectionSort(int[] array)
        {
            SelectionSort selectionSort = new SelectionSort(array);
            selectionSort.Sort();
        }
        public static void InsertionSort(int[] array)
        {
            InsertionSort insertionSort = new InsertionSort(array);
            insertionSort.Sort();
        }

        public static void QuickSort(int[] array)
        {
            QuickSort quickSort = new QuickSort(array);
            quickSort.Sort();
        }

        public static void HeapSort(int[] array)
        {
            HeapSort heapSort = new HeapSort(array);
            heapSort.Sort();
        }
    }
}
