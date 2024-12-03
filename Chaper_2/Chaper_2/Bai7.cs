using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaper_2
{
    internal class Bai7
    {
        public static void Bai7_main()
        {
            Console.Write("Nhap Chieu Dai Mang B: m = ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Nhap Chieu Dai Mang C: n = ");
            int n = int.Parse(Console.ReadLine());
            int[] arrA = new int[m + n], arrB = new int[m], arrC = new int[n];

            Helper.CreateArrayRamDom(arrB, m);
            Helper.CreateArrayRamDom(arrC, n);
            Sort.MergeSort(arrB);
            Sort.MergeSort(arrC);
            Console.WriteLine("Array B: ");
            Helper.Display(arrB);
            Console.WriteLine("Array C: ");
            Helper.Display(arrC);

            Bai7.MergeSortTwoArray(arrA, arrB, arrC);

            Console.WriteLine("Array A:");
            Helper.Display(arrA);

        }

        public static void MergeSortTwoArray(int[] arrA, int[] arrB, int[] arrC)
        {
            int i = 0, j = 0, z = 0;
            while(i < arrB.Length && j < arrC.Length)
            {
                if (arrB[i] < arrC[j])
                {
                    arrA[z] = arrB[i];
                    i++;
                }
                else
                {
                    arrA[z] = arrC[j];
                    j++;
                }
                z++;
            }

            while(i < arrB.Length)
            {
                arrA[z] = arrB[i];
                i++;
                z++;
            }

            while(j < arrC.Length)
            {
                arrA[z] = arrC[j];
                j++;
                z++;
            }
        }
    }
}
