using ex_1.Object;
using ex_1.Search;
using ex_1.Sort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1.Helper
{
    internal class StudentHelper
    {

        public static void EnterStudentList(List<SinhVien> listStudent, int n)
        {
            for (int i = 0; i < n; i++)
            {
                SinhVien sv = new SinhVien();
                listStudent.Add(sv);
            }
        }

        public static void DisplayStudentList(List<SinhVien> list)
        {
            foreach(SinhVien sv in list)
            {
                sv.Display();
            }
        }

        public static SinhVien HightestStudentScore(List<SinhVien> list)
        {
            SinhVien maxScore = list[0];

            foreach(SinhVien sv in list)
            {
                if (maxScore.score < sv.score) maxScore = sv;
            }

            return maxScore;
        }

        public static List<SinhVien> listHightestStudentScoreList(List<SinhVien> list)
        {
            List<SinhVien> l = new List<SinhVien>();
            BubbleSort.Run(list);
            SinhVien sv = BinSearch.Run(list, StudentHelper.HightestStudentScore(list));

            foreach(SinhVien s in list)
            {
                if (s.score == sv.score) l.Add(s);
            }

            return l;
        }
    }
}
