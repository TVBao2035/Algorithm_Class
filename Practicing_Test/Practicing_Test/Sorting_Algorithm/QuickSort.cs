using Sorting_Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicing_Test.Sorting_Algorithm
{
    internal class QuickSort
    {
        private int[] array;
        public QuickSort(int[] array)
        {
            this.array = array;
        }

        public void Sort()
        {
            Console.WriteLine("Quick Sort");
            Run(array, 0, array.Length - 1);
            Helpers.PrintArray(array);
        }
        private void Run(int[] array, int left, int right)
        {
            int mid = (left + right) / 2;
            int i = left, j = right;
            int saved = array[mid];
            while(i < j)
            {
                while (array[i] < saved) i++;
                while (array[j] > saved) j--;

                if(i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }
            if (left < j) Run(array, left, j);
            if (right > i) Run(array, i, right);
        }
    }
}
