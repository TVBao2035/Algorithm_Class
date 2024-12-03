using Chaper_4.Bai_1.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaper_4.Bai_2
{
    internal class Helpers
    {
        public static int ConvertIDToInt(string text)
        {
            string res = text.Substring(3, text.Length - 3);
            return int.Parse(res);
        }

        public static void SortIncreaseById(LinkedList<SinhVien> linkedlist)
        {
            LinkedList<SinhVien> virtualList = linkedlist;
            LinkedListNode<SinhVien> currNodeI = virtualList.First;
            LinkedListNode<SinhVien> currNodeJ;
            while (currNodeI != null)
            {
                currNodeJ = currNodeI.Next;
                while(currNodeJ != null)
                {
                    if(ConvertIDToInt(currNodeJ.Value.MSV) < ConvertIDToInt(currNodeI.Value.MSV))
                    {
                        SinhVien temp = currNodeI.Value;
                        currNodeI.Value = currNodeJ.Value;
                        currNodeJ.Value = temp;
                    }
                    currNodeJ = currNodeJ.Next;
                }
                currNodeI = currNodeI.Next;
            }
            Display(virtualList);
        }

        public static void AvarageScoreOfStudents(LinkedList<SinhVien> linkedlist)
        {
            double sum = 0;
            LinkedListNode<SinhVien> currNode = linkedlist.First;
            while(currNode != null)
            {
                sum += currNode.Value.Diem;
                currNode = currNode.Next;
            }
            Console.WriteLine("Diem Trung Binh Cua Tat Ca Sinh Vien: " + (sum * 1.0 / linkedlist.Count));
        }

        public static void FindStudentById(LinkedList<SinhVien> linkedlist)
        {
            Console.WriteLine("Nhap Ma Sinh Vien:");
            string id = Console.ReadLine();
            LinkedListNode<SinhVien> currNode = linkedlist.First;
            while(currNode != null)
            {
                if(currNode.Value.MSV.ToLower() == id.ToLower())
                {
                    currNode.Value.print();
                    return;
                }
                currNode = currNode.Next;
            }
            Console.WriteLine("Khong Tim Thay Sinh Vien");
        }

        public static void FindMaxScoreStudent(LinkedList<SinhVien> linkedList)
        {
            LinkedListNode<SinhVien> currNode = linkedList.First;
            LinkedListNode<SinhVien> student = linkedList.First;
            while(currNode != null)
            {
                if(currNode.Value.Diem > student.Value.Diem)
                {
                    student = currNode;
                }
                currNode = currNode.Next;
            }
            Console.WriteLine("Sinh Vien Co Diem Cao Nhat");
            student.Value.print();
        }

        public static void EditStudent(LinkedList<SinhVien> linkedList)
        {
            Console.WriteLine("Nhap MSV Can Chinh Sua");
            string msv = Console.ReadLine();
            LinkedListNode<SinhVien> currNode = linkedList.First;
            while (currNode != null)
            {
                if (currNode.Value.MSV.ToLower() == msv.ToLower())
                {
                    break ;
                }
                currNode = currNode.Next;
            }
            currNode.Value.print();
            Console.WriteLine("Chinh Sua Thong Tin Sinh Vien");
            Console.WriteLine("Nhap HoTen: ");
            string hoten = Console.ReadLine();
            Console.WriteLine("Nhap Diem: ");
            double diem = double.Parse(Console.ReadLine());
            currNode.Value.HoTen = hoten;
            currNode.Value.Diem = diem;
            Console.WriteLine("Chinh Sua Thong Tin Sinh Vien Thanh Cong");
        }

        public static void DeleteStudent(LinkedList<SinhVien> linkedlist)
        {
            Console.WriteLine("Nhap MSV Can Xoa");
            string msv = Console.ReadLine();
            LinkedListNode<SinhVien> currNode = linkedlist.First;
            while(currNode != null)
            {
                if(currNode.Value.MSV.ToLower() == msv.ToLower())
                {
                    linkedlist.Remove(currNode);
                    Console.WriteLine("Xoa Sinh Vien Thanh Cong: ");
                    return;
                }
                currNode = currNode.Next;
            }
            Console.WriteLine("Khong Tim Thay Sinh Vien");
            
        }

        public static void AddStudent(LinkedList<SinhVien> linkedlist)
        {
            SinhVien sv = new SinhVien();
            linkedlist.AddLast(new LinkedListNode<SinhVien>(sv));
            Console.WriteLine("Them Sinh Vien Thanh Cong: ");
            sv.print();
        }

        public static void RenderData(LinkedList<SinhVien> linkedlist)
        {
            linkedlist.AddLast(new SinhVien("SV-011", "BaoBao", 3.0));
            linkedlist.AddLast(new SinhVien("SV-002", "BaoBao", 3.5));
            linkedlist.AddLast(new SinhVien("SV-030", "BaoBao", 4.0));
            linkedlist.AddLast(new SinhVien("SV-004", "BaoBao", 4.5));
            linkedlist.AddLast(new SinhVien("SV-005", "BaoBao", 5.0));
        }

        public static void Display(LinkedList<SinhVien> linkedlist)
        {
            foreach (SinhVien sv in linkedlist)
            {
                sv.print();

            }
            Console.WriteLine($"\t\t\t[ Co {linkedlist.Count} Sinh Vien ]");
        }
    }
}
