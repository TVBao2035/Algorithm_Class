using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaper_2
{
    internal class QuickSort
    {
        public static void Run(int[] arr, int left, int right)
        {
            int mid = (right + left) / 2;
            int x = arr[mid];
            int i = left;
            int j = right;
            int temp;
            while (i <= j)
            {
                while (arr[i] < x) i++;
                while (arr[j] > x) j--;
                if(i <=j)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                    j--;
                }
            }

            if (left < j) Run(arr, left, j);
            if (right > i) Run(arr, i, right);
        }
    }
}
