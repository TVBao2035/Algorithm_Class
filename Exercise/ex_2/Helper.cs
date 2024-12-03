using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_2
{
    internal class Helper
    {
        public static bool checkCreaseArray(int[] arr)
        {

            for(int i=0; i<arr.Length-1; i++)
            {
                if (arr[i] > arr[i + 1]) return false;
            }
            return true;
        }

        public static void display(int[] arr)
        {
            foreach (int e in arr) Console.WriteLine(e);
        }

        public static bool IsNguyenTo(int element)
        {
            for(int i=2; i<=Math.Sqrt(element); i++)
            {
                if (element % i == 0) return false;
            }

            return true;
        }

        public static int[] Insert(int[] arr, int x, int position)
        {
            int n = arr.Length;
            int[] result = new int[n + 1];
            for(int i=0; i<n+1; i++)
            {
                if(i < position)
                {
                    result[i] = arr[i];
                }else if(i == position)
                {
                    result[i] = x;
                }
                else
                {
                    result[i] = arr[i - 1];
                }
            }

            return result;
        }
    }
}
