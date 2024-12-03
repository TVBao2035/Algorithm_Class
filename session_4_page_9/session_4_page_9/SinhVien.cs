using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_4_page_9
{
    internal class SinhVien
    {
        private String maSV, hoten;

        public SinhVien(String maSV, String hoten)
        {
            this.maSV = maSV;
            this.hoten = hoten;
        }

        public void display()
        {
            Console.WriteLine("-----------------------\nID: {0}\nHo Ten: {1}", this.maSV, this.hoten);
        }
    }
}
