using Sorting_Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicing_Test.Sorting_Algorithm
{
    internal class InsertionSort
    {
        private int[] array;
        public InsertionSort(int[] array)
        {
            this.array = array;
        }

        public void Sort()
        {
            Console.WriteLine("Insertion Sort");
            int length = array.Length;
            for(int i=1; i<length; i++)
            {
                int j = i-1;
                int valueTemp = array[i];
                while (j >= 0 && valueTemp < array[j] )
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j+1] = valueTemp;

            }

            Helpers.PrintArray(array);
        }
    }
}
