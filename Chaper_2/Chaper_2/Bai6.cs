using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaper_2
{
    internal class Bai6
    {
        public static void MenuBai6()
        {
            int choose;
            do
            {
                Console.WriteLine("++++++++ MENU ++++++++");
                Console.WriteLine("[1]. Bai 6.1");
                Console.WriteLine("[2]. Bai 6.2");
                Console.WriteLine("[3]. Bai 6.3");
                Console.WriteLine("[4]. Bai 6.4");
                Console.Write("=> Option: ");
                choose = int.Parse(Console.ReadLine());
            } while (choose > 4 || choose < 1);
            switch (choose)
            {
                case 1:
                    Bai6.Bai6_1();
                    break;
                case 2:
                    Bai6.Bai6_2();
                    break;
                case 3:
                    Bai6.Bai6_3();
                    break;
                case 4:
                    Bai6.Bai6_4();
                     break;
            }
        }

        public static void Bai6_4()
        {
            Console.Write("Nhap N = ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Helper.CreateArrayRamDom(arr, n);
            Console.WriteLine("Array RamDOm");
            Helper.Display(arr);
            Sort.MergeSort(arr);
            Console.WriteLine("Array Sorted");
            Helper.Display(arr);
        }
        public static void Bai6_1()
        {
            Console.Write("Nhap N = ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Helper.CreateArrayRamDom(arr, n);
            Console.WriteLine("Array RamDOm");
            Helper.Display(arr);
            Sort.HeapSort(arr);
            Console.WriteLine("Array Sorted");
            Helper.Display(arr);
        }

        public static void Bai6_2()
        {
            int n, m;
            do
            {
                Console.Write("Nhap N = ");
                n = int.Parse(Console.ReadLine());
                Console.Write("Nhap M = ");
                m = int.Parse(Console.ReadLine());

            } while (n < m);
            int[] arrA = new int[n], arrB = new int[m];
            Helper.CreateArrayRamDom(arrA, n);
            Console.WriteLine("Array A");
            Helper.Display(arrA);
            Sort.HeapSort(arrA);
            for(int i=0; i < m; i++)
            {
                arrB[i] = arrA[n - i - 1];
            }

            Console.WriteLine("Array B");
            Helper.Display(arrB);

        }

        public static void Bai6_3()
        {
            int n, m;
            do
            {
                Console.Write("Nhap N = ");
                n = int.Parse(Console.ReadLine());
                Console.Write("Nhap M = ");
                m = int.Parse(Console.ReadLine());

            } while (n < m);
            List<SinhVien> listStudents = new List<SinhVien>(n);
            Helper.CreateListStudentAuto(listStudents, n);
            Helper.DisplayListStudent(listStudents);
            Sort.HeapSortStudent(listStudents);
            List<SinhVien> listTopHightestScoreStudents = new List<SinhVien>(m);

            Console.WriteLine($"Top {m} Student has Best Score:");
            for (int i = 0; i < m; i++)
            {
                listTopHightestScoreStudents.Add( listStudents[n - i - 1]);
            }
            Helper.DisplayListStudent(listTopHightestScoreStudents);
        }
    }
}
