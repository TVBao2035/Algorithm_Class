using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.Cau1
{
    internal class Cau1Main
    {
        public Cau1Main()
        {
            int[] a = { 17, 83, 8, 78, 6, 2, 78, 5, 83, 4 };

            Console.Write("Mang a: ");
            print(a);
            int res = findQue(a);
            Console.Write("PrimeNumberFirst theo tuan tu: ");
            if (res == -1) Console.WriteLine("Not Found");
            else Console.WriteLine($"{a[res]} tai vi tri so {res}");
            res = findBinary(a);
            Console.Write("PrimeNumberFirst theo nhi phan: ");
            if (res == -1) Console.WriteLine("Not Found");
            else Console.WriteLine($"{a[res]} tai vi tri so {res}");

        }
        public void sort(int[] a)
        {
            for (int i = a.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
        }
        public int findBinary(int[] a)
        {
            sort(a);
            int x = -1;

            for (int i = 0; i < a.Length; i++)
            {
                if (isPrimeNumber(a[i]))
                {
                    x = a[i];
                    break;
                }
            }

            int left = 0, right = a.Length - 1;
            int mid = (left + right) / 2;
            while (left <= right)
            {
                mid = (left + right) / 2;
                if (x == a[mid]) return mid;

                if (a[mid] < x) left = mid + 1;

                if (a[mid] > x) right = mid - 1;
            }
            return -1;
        }

        public void print(int[] arr)
        {
            foreach (int num in arr) Console.Write(num + " ");
            Console.WriteLine();
        }


        public int findQue(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (isPrimeNumber(arr[i])) return i;
            }
            return -1;
        }
        public bool isPrimeNumber(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
    }
}
