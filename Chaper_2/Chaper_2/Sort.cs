using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Chaper_2
{
    internal class Sort
    {
        public static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = n - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        public static void SelectionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[minIndex] > arr[j])
                    {
                        minIndex = j;
                    }
                }
                int tempt = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = tempt;
            }
        }

        public static void InsertSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int value = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > value)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = value;
            }
        }

        public static void QuickSort(int[] arr, int left, int right)
        {
            int mid = (right + left) / 2;
            int x = arr[mid], i = left, j = right;

            while (i < j)
            {
                while (arr[i] < x)
                {
                    i++;
                }

                while (arr[j] > x)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                    j--;
                }
            }

            if (left < j)
            {
                QuickSort(arr, left, j);
            }

            if (right > i)
            {
                QuickSort(arr, i, right);
            }
        }

        public static void createHeap(int[] arr)
        {
            for(int i=arr.Length/ 2-1; i>=0; i--)
            {
                AdjusHeap(arr, i, arr.Length - 1);
            }
        }
        public static void AdjusHeap(int[] arr, int iRoot, int iEnd)
        {
            int saved = arr[iRoot];
            int i = iRoot;
            int j = 2 * i + 1;

            while(j <= iEnd)
            {
                if (j + 1 <= iEnd && arr[j] < arr[j + 1]) j++;

                if (arr[j] < saved) break;
                else
                {
                    arr[i] = arr[j];
                    arr[j] = saved;
                    i = j;
                    j = 2 * i + 1;
                }
            }
        }
        public static void HeapSort(int[] arr)
        {
            createHeap(arr);

            int iEnd = arr.Length - 1;
            while(iEnd > 0)
            {
                int temp = arr[iEnd];
                arr[iEnd] = arr[0];
                arr[0] = temp;

                iEnd--;
                AdjusHeap(arr, 0, iEnd);
            }
        }

        public static void createHeapStudent(List<SinhVien> list)
        {
            for(int i = list.Count/2 -1; i>=0; i--)
            {
                AdjusHeapStudent(list, i, list.Count - 1);
            }
        }

        public static void AdjusHeapStudent(List<SinhVien> list, int iRoot, int iEnd)
        {
            SinhVien saved = list[iRoot];
            int i = iRoot;
            int j = 2 * i + 1;
            while(j <= iEnd)
            {
                if (j + 1 <= iEnd && list[j].DiemTrungBinh < list[j + 1].DiemTrungBinh) j++;

                if (list[j].DiemTrungBinh < saved.DiemTrungBinh) break;
                else
                {
                    list[i] = list[j];
                    list[j] = saved;
                    i = j;
                    j = 2 * i + 1;
                }
            }
        }

        public static void HeapSortStudent(List<SinhVien> list)
        {
            createHeapStudent(list);

            int iEnd = list.Count - 1;

            while(iEnd > 0)
            {
                SinhVien temp = list[0];
                list[0] = list[iEnd];
                list[iEnd] = temp;

                iEnd--;
                AdjusHeapStudent(list, 0, iEnd);
            }
        }


        public static void MergeSort(int[] arr)
        {
           if(arr.Length > 1)
            {
                int left = 0;
                int right = arr.Length ;
                int mid = (right - left) / 2;

                int[] arr1 = new int[mid];
                int[] arr2 = new int[right - mid];

                int i = 0, j = 0, z = 0;
                for(i=left; i<mid; i++)
                {
                    arr1[i] = arr[i];
                }

                for(int l = mid; l < right; l++)
                {
                    arr2[j] = arr[l];
                    j++;
                }

                MergeSort(arr1);
                MergeSort(arr2);

                i = 0;
                j = 0;
                while(i < arr1.Length && j < arr2.Length)
                {
                    if (arr1[i] < arr2[j])
                    {
                        arr[z] = arr1[i];
                        i++;
                    }
                    else
                    {
                        arr[z] = arr2[j];
                        j++;
                    }
                    z++;
                }

                while (i < arr1.Length)
                {
                    arr[z] = arr1[i];
                    i++;
                    z++;
                }

                while(j < arr2.Length)
                {
                    arr[z] = arr2[j];
                    j++;
                    z++;
                }

            }
        }
    }
}
