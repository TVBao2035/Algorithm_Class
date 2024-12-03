using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaper_2
{
    internal class Helper
    {
        public static void DisplayArray(int[] arr, int lenght)
        {
            for (int i = 0; i < lenght; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }

        public static void Display(int[] arr)
        {
            foreach (int element in arr)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();
        }


        public static void EnterArray(int[] array, int length)
        {
            for(int i=0; i<length; i++)
            {
                Console.Write($"Nhap Phan Tu A[{i}]:");
                array[i] = int.Parse(Console.ReadLine());
            }
        }
        public static void CreateArrayRamDom(int[] arr, int length)
        {
            Random rd = new Random();
            for(int i=0; i<length; i++)
            {
                arr[i] = rd.Next(1, 1000);
            }
        }

        public static void CreateListStudentAuto(List<SinhVien> list, int n)
        {
            Random rd = new Random();
            for(int i=0; i<n; i++)
            {

                SinhVien sv = new SinhVien($"SV-{i+1}", $"Nguyen Van {Convert.ToChar(rd.Next(0, 257))}", Math.Round(rd.NextDouble() * 10, 2));
                list.Add(sv);
            }
        }

        public static void DisplayListStudent(List<SinhVien> list)
        {
            foreach(SinhVien sv in list)
            {
                sv.Display();
            }
        }


    }
}
