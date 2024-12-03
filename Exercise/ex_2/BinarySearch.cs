using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_2
{
    internal class BinarySearch
    {
        public static int Search(int[] arr, int x)
        {
            int left = 0, right = arr.Length - 1;
                    
            while(left < right)
            {
                int mid = right + left / 2;
                if (arr[mid] == x) return x;

                if (arr[mid] < x) left = mid + 1;
                if (arr[mid] > x) right = mid - 1;
            }

            return -1;
        }
    }
}
