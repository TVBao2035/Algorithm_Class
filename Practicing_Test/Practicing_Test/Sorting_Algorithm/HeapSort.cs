using Sorting_Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicing_Test.Sorting_Algorithm
{
    internal class HeapSort
    {
        private int[] array;
        public HeapSort(int[] array)
        {
            this.array = array;
        }

        public void Sort()
        {
            Console.WriteLine("Heap Sort");
           Run(array);
            Helpers.PrintArray(array);
        }

        private void AdjustHeap(int[] array, int rootIndex, int endIndex)
        {
            int saved = array[rootIndex];
            int i = rootIndex;
            int j = 2 * i + 1;
            while(j <= endIndex)
            {
                if ((j + 1) <= endIndex && array[j] < array[j + 1])
                    j++;
                if (array[j] <= saved) break;
                array[i] = array[j];
                array[j] = saved;
                i = j;
                j = 2 * i + 1;
            }
        }
        private void CreateHeap(int[] array)
        {
            int length = array.Length;
            for (int i = (length / 2) + 1; i >= 0; i--)
                AdjustHeap(array, i, length - 1);
        }

        private void Run(int[] array)
        {
            CreateHeap(array);
            int endIndex = array.Length - 1;
            while(endIndex >= 0)
            {
                int temp = array[endIndex];
                array[endIndex] = array[0];
                array[0] = temp;

                endIndex--;
                AdjustHeap(array, 0, endIndex);
            }
        }
    }
}
