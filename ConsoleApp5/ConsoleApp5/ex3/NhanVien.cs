using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.ex3
{
    internal class NhanVien
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public int GioiTinh { get; set; }
        public int NgaySinh { get; set; }
        public int Luong { get; set; }

        public void enter()
        {
            Console.WriteLine("Ma nv: ");
            MaNV = Console.ReadLine();
            Console.WriteLine("Luong: ");
            Luong = int.Parse(Console.ReadLine());
            Console.WriteLine("HoTen: ");
            HoTen = Console.ReadLine();
            Console.WriteLine("GioiTinh: ");
            GioiTinh = int.Parse(Console.ReadLine());
            Console.WriteLine("NgaySinh: ");
            NgaySinh = int.Parse(Console.ReadLine());

        }
        public void print()
        {
            Console.WriteLine("MaNV: " + MaNV);
            Console.WriteLine("Luong: " + Luong);
            Console.WriteLine("HoTen: " + HoTen);
            Console.WriteLine("GioiTinh: " + GioiTinh);
            Console.WriteLine("NgaySinh: " + NgaySinh);
            Console.WriteLine();
        }
    }
}
