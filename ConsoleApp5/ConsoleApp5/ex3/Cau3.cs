using ConsoleApp5.ex2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.ex3
{
    internal class Cau3
    {
        public Cau3()
        {
            LinkedList nvl = new LinkedList();
            enter(nvl);
            print(nvl);

            List<NhanVien> list = new List<NhanVien>();
            addToList(list, nvl.root);
            Console.WriteLine("++++++++QUICK SORT +++++++++++++++");

            QuickSort(list, 0, list.Count - 1);
            foreach (var v in list) v.print();
            Console.WriteLine("++++++++ Min Salary List +++++++++++++++");
            LinkedList<NhanVien> ll = new LinkedList<NhanVien>(list);
            foreach (var v in minSalaryList(ll)) v.print();
          
        }

        public LinkedList<NhanVien> minSalaryList(LinkedList<NhanVien> ll)
        {
            LinkedList<NhanVien> res = new LinkedList<NhanVien>();
            LinkedListNode<NhanVien> curr = ll.First;
            int minSalary = curr.Value.Luong;

            while(curr != null)
            {
                if (minSalary > curr.Value.Luong) minSalary = curr.Value.Luong;
                curr = curr.Next;
            }
        
            curr = ll.First;
            while (curr != null)
            {
                if (minSalary == curr.Value.Luong) res.AddLast(curr.Value);
                curr = curr.Next;
            }

            return res;
        }
        public void QuickSort(List<NhanVien> list, int left , int right)
        {
            int mid = (left + right) / 2;
            int i = left;
            int j = right;
            NhanVien temp = list[mid];
            while(i < j)
            {
                while (list[i].Luong > temp.Luong) i++;
                while (list[j].Luong < temp.Luong) j--;

                if(i<=j)
                {
                    NhanVien saved = list[i];
                    list[i] = list[j];
                    list[j] = saved;
                    i++;
                    j--;
                }
            }
            if (left < j) QuickSort(list, left, j);
            if (right > i) QuickSort(list, i, right);
        }
        public void addToList(List<NhanVien> list, Node root)
        {
            Node curr = root;
            while (curr != null)
            {
                NhanVien nv = (NhanVien)curr.value;
                list.Add(nv);
                curr = curr.next;
            }
        }
        public void print(LinkedList nvl)
        {
            Node curr = nvl.root;
            while(curr != null)
            {
                NhanVien nv = (NhanVien)curr.value;
                nv.print();
                curr = curr.next;
            }
        }
        public void enter(LinkedList nvl)
        {
            Console.WriteLine("N :");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i< n; i++)
            {
                NhanVien nv = new NhanVien();

                nv.enter();
                nvl.AddNode(nv);
            }
           
        }
    }
}
