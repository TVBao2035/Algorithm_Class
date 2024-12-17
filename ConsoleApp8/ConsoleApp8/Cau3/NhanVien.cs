using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.Cau3.Cau3
{
    internal class NhanVien
    {
        public string MaNhanVien { get; set; }
        public string HoTen { get; set; }
        public int GioiTinh { get; set; }
        public int NamSinh { get; set; }
        public int TienThuong { get; set; }

        public void print()
        {
            Console.WriteLine();
            Console.WriteLine($"MaNV: {MaNhanVien}");
            Console.WriteLine($"HoTen: {HoTen}");
            Console.WriteLine($"GioiTinh: {GioiTinh}");
            Console.WriteLine($"NamSinh: {NamSinh}");
            Console.WriteLine($"TienThuong: {TienThuong}");
        }

        public void insert()
        {
            Console.WriteLine($"MaNV:");
            MaNhanVien = Console.ReadLine();
            Console.WriteLine($"HoTen:");
            HoTen = Console.ReadLine();
            Console.WriteLine($"GioiTinh:");
            GioiTinh = int.Parse(Console.ReadLine());
            Console.WriteLine($"NamSinh:");
            NamSinh = int.Parse(Console.ReadLine());
            Console.WriteLine($"TienThuong: ");
            TienThuong = int.Parse(Console.ReadLine());
        }
    }
}
