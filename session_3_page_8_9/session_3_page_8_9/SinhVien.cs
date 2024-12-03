using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_3_page_8_9
{
    internal class SinhVien
    {
        private String hoten, maSV;
        private double diemTB;

        public String HoTen
        {
            get; set;
        }

        public String MaSinhVien
        {
            get; set;
        }

        public double DiemTrungBinh
        {
            get; set;
        }


        public SinhVien(String hoten, String maSV, double diemTB)
        {
            this.hoten = hoten;
            this.maSV = maSV;
            this.diemTB = diemTB;
        }

        public void display()
        {
            Console.WriteLine("Ma Sinh Vien: {0}\nHo Ten: {1}\nDiem Trung Binh: {2}", this.maSV, this.hoten, this.diemTB);
        }
    }
}
