using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaper_2
{
    internal class Search
    {
        public static int SequentialSearch(int[] arr, int x)
        {
            for(int i=0; i<arr.Length; i++)
            {
                if (arr[i] == x) return i;
            }

            return -1;

        }


        public static int BinarySearch(int[] arr, int x)
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left <= right)
            {
                int mid = (right + left) / 2;

                if (arr[mid] == x) return mid;

                if (arr[mid] < x) left = mid + 1;

                if (arr[mid] > x) right = mid - 1;

            }

            return -1;
        }

        public static int _BinarySearch(int[] arr, int x , int left, int right)
        {
            if(left <= right)
            {
                int mid = (right + left) / 2;
                if (arr[mid] == x) return mid;

                if (arr[mid] > x) return _BinarySearch(arr, x, left, mid - 1);

                if (arr[mid] < x) return _BinarySearch(arr, x, mid + 1, right);
            }
            return -1;
        }


        public static int Search_First_Element_Index(int[] arr, int x)
        {
            for(int i=0; i<arr.Length; i++)
            {
                if (arr[i] == x) return i;
            }
            return -1;

        }

        public static int Search_Last_Element_Index(int[] arr, int x)
        {
            int index = -1;
            for(int i=0; i<arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    index = i;
                }
            }
            return index;
        }

        public static List<int> Search_All_Element(int[] arr, int x)
        {
            List<int> elementList = new List<int>();
            for(int i=0; i<arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    elementList.Add(i);
                }
            }
            return elementList;
        } 

        public static int Search_First_Smallest_Element(int[] arr)
        {
            int minIndex = 0;
            for(int i=1; i<arr.Length; i++)
            {
                if (arr[minIndex] > arr[i]) minIndex = i;
            }

            return minIndex;
        }

        public static int Search_Last_Biggest_Element(int[] arr)
        {
            int maxIndex = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[maxIndex] <= arr[i]) maxIndex = i;
            }

            return maxIndex;
        }

        public static List<int> Search_All_Smallest_Element(int[] arr)
        {
            List<int> indexList = new List<int>();

            int minIndex = Search_First_Smallest_Element(arr);

            for(int i=0; i<arr.Length; i++)
            {
                if (arr[minIndex] == arr[i]) indexList.Add(i);
            }

            return indexList;
        }

        public static int Search_First_Odd_Biggest_Element(int[] arr)
        {
            int maxIndex = 0;

            for(int i=0; i<arr.Length; i++)
            {
                if (arr[i]%2 != 0 && arr[i] > arr[maxIndex])
                {
                    maxIndex = i;
                }
            }

            return maxIndex;
        }

        public static int Search_Last_Even_Biggest_Element(int[] arr)
        {
            int maxIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0 && arr[i] >= arr[maxIndex])
                {
                    maxIndex = i;
                }
            }

            return maxIndex;
        }
    }
}
