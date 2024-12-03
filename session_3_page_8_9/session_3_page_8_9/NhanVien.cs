using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_3_page_8_9
{
    internal class NhanVien
    {
        private String hoten, maNhanVien;
        private int heSoLuong;

        public String HoTen
        {
            get; set;
        }
        public String MaNhanVien
        {
            get; set;
        }

        public int HeSoLuong
        {
            get; set;
        }

        public NhanVien(String hoten, String maNhanVien, int heSoLuong)
        {
            this.hoten = hoten;
            this.maNhanVien = maNhanVien;
            this.heSoLuong = heSoLuong;
        }
        public void display()
        {
            Console.WriteLine("Ma Nhan Vien: {0}\nHo Ten: {1}\nHe So Luong: {2}", this.maNhanVien, this.hoten, this.heSoLuong);
        }
    }
}
