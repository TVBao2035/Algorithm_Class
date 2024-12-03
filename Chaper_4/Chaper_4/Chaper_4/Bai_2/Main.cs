using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaper_4.Bai_2
{
    internal class Main
    {
        public Main()
        {
            var linkedlist = new LinkedList<SinhVien>();
            Helpers.RenderData(linkedlist);
            Menu(linkedlist);
        }

        public void Menu(LinkedList<SinhVien> linkedlist)
        {
            int option;
            while (true)
            {
                Console.Clear();
                do
                {
                    Console.WriteLine("Bai 2");
                    Console.WriteLine("[1]. Hien Thi Danh Sach Sinh Vien");
                    Console.WriteLine("[2]. Them Sinh Vien");
                    Console.WriteLine("[3]. Xoa Sinh Vien");
                    Console.WriteLine("[4]. Sua Thong Tin Sinh Vien");
                    Console.WriteLine("[5]. Tim Sinh Vien Theo Ma Sinh Vien");
                    Console.WriteLine("[6]. Sinh Vien Co Diem Cao Nhat");
                    Console.WriteLine("[7]. Diem Trung Binh Cua Tat Sinh Vien");
                    Console.WriteLine("[8]. Sap Xep Theo Ma Sinh Vien Tang");
                    Console.WriteLine("[0]. Thoat");
                    Console.Write("Nhap Lua Chon:");
                    option = int.Parse(Console.ReadLine());
                    if (option == 0) return;
                } while (option < 1 || option > 8);

                switch (option)
                {
                    case 1:
                        Helpers.Display(linkedlist);
                        Console.ReadLine();
                        break;
                    case 2:
                        Helpers.AddStudent(linkedlist);
                        Console.ReadLine();
                        break;
                    case 3:
                        Helpers.DeleteStudent(linkedlist);
                        Console.ReadLine();
                        break;
                    case 4:
                        Helpers.EditStudent(linkedlist);
                        Console.ReadLine();
                        break;
                    case 5:
                        Helpers.FindStudentById(linkedlist);
                        Console.ReadLine();
                        break;
                    case 6:
                        Helpers.FindMaxScoreStudent(linkedlist);
                        Console.ReadLine();
                        break;
                    case 7:
                        Helpers.AvarageScoreOfStudents(linkedlist);
                        Console.ReadLine();
                        break;
                    case 8:
                        Helpers.SortIncreaseById(linkedlist);
                        Console.ReadLine();
                        break;

                }
            }
        }

      
    }
}
