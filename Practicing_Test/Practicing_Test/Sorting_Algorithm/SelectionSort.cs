using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms.Sorts
{
    internal class SelectionSort
    {
        public int[] array { get; set; }
        public SelectionSort(int[] arr)
        {
            array = arr;
        }
        public void Sort()
        {
            Console.WriteLine("Selection Sort");
            int length = array.Length;
            for(int i=0; i<length-1; i++)
            {
                int minIndex = i;
                for(int j=i+1; j < length; j++)
                {
                    if (array[minIndex] > array[j])
                    {
                        minIndex = j;
                    }
                }
                int tempt = array[minIndex];
                array[minIndex] = array[i];
                array[i] = tempt;
            }
            Helpers.PrintArray(array);
        }
    }
}
