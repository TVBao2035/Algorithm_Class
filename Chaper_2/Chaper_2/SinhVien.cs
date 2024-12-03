using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaper_2
{
    internal class SinhVien
    {
        public String Id
        {
            get; set;
        }

        public String Hoten
        {
            get; set;
        }

        public Double DiemTrungBinh
        {
            get; set;
        }

        public SinhVien(String id, String name, double diem)
        {
            Id = id;
            Hoten = name;
            DiemTrungBinh = diem;
        }
        public void Enter()
        {
            Console.Write("Id = ");
            Id = Console.ReadLine();
            Console.Write("Ho Ten = ");
            Hoten = Console.ReadLine();
            Console.Write("Diem Trung Binh = ");
            DiemTrungBinh = double.Parse(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine("==============================");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Name: {Hoten}");
            Console.WriteLine($"DTB: {DiemTrungBinh}");
            Console.WriteLine("==============================\n");
        }

        public static SinhVien Search_First_Scored_Student(List<SinhVien> listSV, double x)
        {
            foreach(SinhVien sv in listSV)
            {
                if (sv.DiemTrungBinh == x) return sv;
            }
            return null;
        }

        public static SinhVien Search_Last_Scored_Student(List<SinhVien> listSV, double x)
        {
            SinhVien temp = null;
            foreach (SinhVien sv in listSV)
            {
                if (sv.DiemTrungBinh == x)  temp = sv;
            }
            return temp;
        }

        public static List<SinhVien> Search_All_Students(List<SinhVien> listSV, double x)
        {
            List<SinhVien> list = new List<SinhVien>();
            foreach (SinhVien sv in listSV)
            {
                if (sv.DiemTrungBinh == x) list.Add(sv);
            }
            return list;
        }

        public static SinhVien Search_First_Smallest_Score_Student(List<SinhVien> list)
        {
            double scoreTemp = list[0].DiemTrungBinh;
            foreach (SinhVien sv in list)
            {
                if (scoreTemp > sv.DiemTrungBinh) scoreTemp = sv.DiemTrungBinh;
            }
            foreach(SinhVien sv in list)
            {
                if (scoreTemp == sv.DiemTrungBinh) return sv;
            }
            return null;
        }

        public static SinhVien Search_Last_Biggest_Score_Student(List<SinhVien> list)
        {
            double scoreTemp = list[0].DiemTrungBinh;
            foreach (SinhVien sv in list)
            {
                if (scoreTemp <= sv.DiemTrungBinh) scoreTemp = sv.DiemTrungBinh;
            }
            SinhVien temp = null;
            foreach (SinhVien sv in list)
            {
                if (scoreTemp == sv.DiemTrungBinh) temp =  sv;
            }
            return temp;
        }
        public static List<SinhVien> Search_All_Student_Smallest_Score(List<SinhVien> listSV)
        {
            List<SinhVien> temp = new List<SinhVien>();
            double scoreTemp = listSV[0].DiemTrungBinh;
            foreach(SinhVien sv in listSV)
            {
                if (scoreTemp > sv.DiemTrungBinh) scoreTemp = sv.DiemTrungBinh;
            }

            foreach(SinhVien sv in listSV)
            {
                if (sv.DiemTrungBinh == scoreTemp) temp.Add(sv);
            }

            return temp;
        }
        public static void Sort_Students(List<SinhVien> listSV)
        {
           for(int i=listSV.Count-1; i>=0; i--)
            {
                for(int j=0; j<i; j++)
                {
                    if (listSV[j].DiemTrungBinh > listSV[j + 1].DiemTrungBinh)
                    {
                        SinhVien temp = listSV[j];
                        listSV[j] = listSV[j + 1];
                        listSV[j + 1] = temp;
                    }
                }
            }
           
        }
    }
}
