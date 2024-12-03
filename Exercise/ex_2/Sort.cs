using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_2
{
    internal class Sort
    {
        public static void HeapSort(int[] arr)
        {
            Console.WriteLine("HEAP SORT");
            CreateHeap(arr);
            int iEnd = arr.Length - 1;
            int temp;
            while(iEnd >= 0)
            {
                temp = arr[0];
                arr[0] = arr[iEnd];
                arr[iEnd] = temp;

                iEnd--;
                AdjustHeap(arr, 0, iEnd);
            }
        }

        public static void AdjustHeap(int[] arr, int iRoot, int iEnd)
        {
            int saved = arr[iRoot];
            int i = iRoot;
            int j = 2 * i + 1;

            while(j <= iEnd)
            {
                if (j + 1 <= iEnd && arr[j + 1] > arr[j]) j++;

                if (arr[j] < saved) break;

                arr[i] = arr[j];
                arr[j] = saved;
                i = j;
                j = 2 * i + 1;
            }
        }

        public static void CreateHeap(int[] arr)
        {
            int n = arr.Length;
            for(int i = n/2 -1; i>=0; i--)
            {
                AdjustHeap(arr, i, n - 1);
            }
        }
    }
}
