using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_2_page_8
{
    internal class Student
    {
        public String studentId;
        public int M1, M2, M3;

        public Student(String studentId, int M1, int M2, int M3)
        {
            this.studentId = studentId;
            this.M1 = M1;
            this.M2 = M2;
            this.M3 = M3;
        }

      
        public double totalScored()
        {
            return (M1 + M2 + M3)/3;
        }

        public void display()
        {
            Console.WriteLine("ID: {0}\nM1: {1}\nM2: {2}\nM3: {3}\ntotal: {4}", studentId, M1, M2, M3, totalScored());
        }
    }
}
