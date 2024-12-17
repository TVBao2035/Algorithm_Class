using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.ex1
{
    internal class Cau1
    {
        public Cau1()
        {
            int n;
            Console.WriteLine("Nhap n: ");
            n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for(int i=0; i< n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Mang a: ");
            print(array);
            Console.Write("\nOddFirst theo tuan tu: ");
            int res = SeqSearch(array);
            if (res == -1)
            {
                Console.WriteLine("Not Found");
            }
            else Console.WriteLine($"{array[res]} tai vi tri so {res}");

            Console.Write("\nOddFirst theo nhi phan: ");
            res = BinarySearch(array);
            if (res == -1)
            {
                Console.WriteLine("Not Found");
            }
            else Console.WriteLine($"{array[res]} tai vi tri so {res}");
        }
        public void print(int[] arr)
        {
            foreach (int num in arr) Console.Write(num + " ");
        }
        public int SeqSearch(int[] arr)
        {
            for(int i=0; i<arr.Length; i++)
            {
                if (arr[i] % 2 != 0) return i;
            }

            return -1;
        }

        public int BinarySearch(int[] arr)
        {
            for(int i=0; i< arr.Length; i++)
            {
                for(int j =0; j < arr.Length-2 -i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            int oddNum = arr[SeqSearch(arr)];
            int left = 0, right = arr.Length - 1;
            int mid;
            while(left <= right)
            {
                mid = (left + right) / 2;
                if (arr[mid] == oddNum) return mid;
                if (arr[mid] < oddNum) left = mid + 1;
                if (arr[mid] > oddNum) right = mid - 1;
            }
            return -1;
        }
    }
}
