using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaper_4.Bai_2
{
    internal class SinhVien
    {
        public string MSV { get; set; }
        public string HoTen { get; set; }
        public double Diem { get; set; }

        public SinhVien(string msv, string hoten, double diem) {
            MSV = msv;
            HoTen = hoten;
            Diem = diem;
        }

        public SinhVien()
        {
            Console.Write("Nhap Ma Sinh Vien: ");
            MSV = Console.ReadLine();
            Console.Write("Nhap Ho Ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap Diem: ");
            Diem = double.Parse(Console.ReadLine());
        }

        public void print()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"MSV: {MSV}\nHoten: {HoTen}\nDiem: {Diem}");
        }
    }
}
