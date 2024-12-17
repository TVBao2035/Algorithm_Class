using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms.Sorts
{
    internal class BubbleSort
    {
        public int[] Array { get; set; }
        public BubbleSort(int[] array)
        {
            Array = array;
        }
        public void Sort()
        {
            Console.WriteLine("Bubble Sort");
            for(int i=0; i<Array.Length; i++)
            {
                for(int j=Array.Length-1; j > i; j--)
                {
                    if (Array[j] < Array[j - 1])
                    {
                        int tempt = Array[j];
                        Array[j] = Array[j - 1];
                        Array[j - 1] = tempt;
                    }
                }
            }
            Helpers.PrintArray(Array);
        }

        
    }
}
