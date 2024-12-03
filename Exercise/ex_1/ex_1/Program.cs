using ex_1.Helper;
using ex_1.Object;
using ex_1.Search;
using ex_1.Sort;

namespace ex_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
      /*      Console.Write("Enter N = ");
            int n = int.Parse(Console.ReadLine());*/
            List<SinhVien> listStudent = new List<SinhVien>() {
                new SinhVien(111, "Van Bao", 2.3),
                new SinhVien(222, "Van Bao 1", 2.1),
                  new SinhVien(121, "Van Bao 2", 5.3),
                new SinhVien(212, "Van Bao 3", 8.1),
                  new SinhVien(311, "Van Bao 4", 2.3),
                new SinhVien(224, "Bao Bao", 8.1),
            };

            StudentHelper.DisplayStudentList( StudentHelper.listHightestStudentScoreList(listStudent));
           /* StudentHelper.EnterStudentList(listStudent, n);*/
            //StudentHelper.DisplayStudentList(listStudent);

          
        }
    }
}
