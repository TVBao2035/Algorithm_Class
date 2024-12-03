using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaper_2
{
    internal class Bai_Tap_Them
    {
        public static void Bai_Tap()
        {
            int choose;
            do
            {
                Console.WriteLine("++++++++ MENU ++++++++");
                Console.WriteLine("[1]. Bai 1.1");
                Console.WriteLine("[2]. Bai 1.2");
                Console.WriteLine("[3]. Bai 1.3");
                Console.WriteLine("[4]. Bai 1.4");
                Console.WriteLine("[5]. Bai 1.5");
                Console.WriteLine("[6]. Bai 1.6");
                Console.Write("=> Option: ");
                choose = int.Parse(Console.ReadLine());
            } while (choose > 6 || choose < 1);

            switch (choose)
            {
                case 1:
                    Bai1_1();
                    break;
                case 2:
                    Bai1_2();
                    break;
                case 3:
                    Bai1_3();
                    break;
                case 4:
                    Bai1_4();
                    break;
                case 5:
                    Bai1_5();
                    break;
                case 6:
                      Bai1_6();
                    break;
            }

        }

        public static void Bai1_1()
        {
            List<SinhVien> listSV = new List<SinhVien>();
            Helper.CreateListStudentAuto(listSV, 100);
            Helper.DisplayListStudent(listSV);
            Console.Write("Nhap Diem X = ");
            double x = double.Parse(Console.ReadLine());
            SinhVien sv = SinhVien.Search_First_Scored_Student(listSV, x);

            if (sv != null)
            {
                Console.Clear();
                Console.WriteLine($"Sinh Vien Co Diem {x} Dau Tien:");
                sv.Display();
            }
            else
            {
                Console.WriteLine("NOT FOUND");
            }
        }

        public static void Bai1_2()
        {
            List<SinhVien> listSV = new List<SinhVien>();
            Helper.CreateListStudentAuto(listSV, 100);
            Helper.DisplayListStudent(listSV);
            Console.Write("Nhap Diem X = ");
            double x = double.Parse(Console.ReadLine());
            SinhVien sv = SinhVien.Search_Last_Scored_Student(listSV, x);

            if (sv != null)
            {
                Console.Clear();
                Console.WriteLine($"Sinh Vien Co Diem {x} Sau Cung:");
                sv.Display();
            }
            else
            {
                Console.WriteLine("NOT FOUND");
            }

        }

        public static void Bai1_3()
        {
            List<SinhVien> listSV = new List<SinhVien>();
            Helper.CreateListStudentAuto(listSV, 100);
            SinhVien.Sort_Students(listSV);
            Helper.DisplayListStudent(listSV);
            Console.Write("Nhap Diem X = ");
            double x = double.Parse(Console.ReadLine());
            List<SinhVien> sv = SinhVien.Search_All_Students(listSV, x);

            if (sv.Count != 0)
            {
                Console.Clear();
                Console.WriteLine($"Sinh Vien Co Diem {x}:");

                Helper.DisplayListStudent(sv);
            }
            else
            {
                Console.WriteLine("NOT FOUND");
            }

        }

        public static void Bai1_4()
        {
            List<SinhVien> listSV = new List<SinhVien>();
            Helper.CreateListStudentAuto(listSV, 100);
            SinhVien.Sort_Students(listSV);
            Helper.DisplayListStudent(listSV);
            
            SinhVien sv = SinhVien.Search_First_Smallest_Score_Student(listSV);

            if (sv != null)
            {
                Console.Clear();
                Console.WriteLine($"Sinh Vien Co Diem Diem Nho Nhat:");

                sv.Display();
            }
            else
            {
                Console.WriteLine("NOT FOUND");
            }

        }

        public static void Bai1_5()
        {
            List<SinhVien> listSV = new List<SinhVien>();
            Helper.CreateListStudentAuto(listSV, 100);
            SinhVien.Sort_Students(listSV);
            Helper.DisplayListStudent(listSV);

            SinhVien sv = SinhVien.Search_Last_Biggest_Score_Student(listSV);

            if (sv != null)
            {
                Console.Clear();
                Console.WriteLine($"Sinh Vien Co Diem Diem Lon Nhat:");

                sv.Display();
            }
            else
            {
                Console.WriteLine("NOT FOUND");
            }

        }

        public static void Bai1_6()
        {
            List<SinhVien> listSV = new List<SinhVien>();
            Helper.CreateListStudentAuto(listSV, 100);
            SinhVien.Sort_Students(listSV);
            Helper.DisplayListStudent(listSV);
           
            List<SinhVien> sv = SinhVien.Search_All_Student_Smallest_Score(listSV);

            if (sv.Count != 0)
            {
                Console.Clear();
                Console.WriteLine($"Tat Ca Sinh Vien Co Diem Nho Nhat :");

                Helper.DisplayListStudent(sv);
            }
            else
            {
                Console.WriteLine("NOT FOUND");
            }
        }
    }
}
