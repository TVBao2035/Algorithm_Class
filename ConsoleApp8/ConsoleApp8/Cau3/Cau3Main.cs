using ConsoleApp8.Cau3.Cau3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.Cau3
{
    internal class Cau3Main
    {
        public Cau3Main()
        {
            
            LinkedList<NhanVien> nhanVienList = new LinkedList<NhanVien>();
            EnterNhanVien(nhanVienList);
            Console.WriteLine("++++++++++InsertSort++++++++++");
            InsertionSort(nhanVienList);
            foreach (var nv in nhanVienList) nv.print();

            Console.WriteLine("++++++++++Max Salary++++++++++");
            foreach (var nv in findMaxSalary(nhanVienList)) nv.print();
        }

        public LinkedList<NhanVien> findMaxSalary(LinkedList<NhanVien> nhanVienList)
        {
            int maxSalary = nhanVienList.ElementAt(0).TienThuong;
            foreach(var nv in nhanVienList)
            {
                if (nv.TienThuong > maxSalary) maxSalary = nv.TienThuong;
            }
            LinkedList<NhanVien> res = new LinkedList<NhanVien>();
            foreach (var nv in nhanVienList)
            {
                if (nv.TienThuong == maxSalary) res.AddLast(nv);
            }

            return res;
        }
        public void InsertionSort(LinkedList<NhanVien> nhanVienList)
        {
            List<NhanVien> nvlist = new List<NhanVien>();
            foreach (var nv in nhanVienList) nvlist.Add(nv);

            for (int i=1; i < nvlist.Count; i++)
            {
                NhanVien temp = nvlist[i];
                int j = i - 1;
                while(j >= 0 && temp.NamSinh > nvlist[j].NamSinh)
                {
                    nvlist[j + 1] = nvlist[j];
                    j--;
                }
                nvlist[j + 1] = temp;

            }
            nhanVienList.Clear();
            foreach (var nv in nvlist) nhanVienList.AddLast(nv);
           
        }
        public void EnterNhanVien(LinkedList<NhanVien> nhanVienList)
        {
            int n;
            do
            {
                Console.Clear();
                NhanVien nv = new NhanVien();
                nv.insert();
                nhanVienList.AddLast(nv);
                Console.WriteLine("[0].Stop");
                try
                {
                    n = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    n = -1;
                }

            } while (n != 0);

            foreach (var nv in nhanVienList) nv.print();
        }
    }
}
