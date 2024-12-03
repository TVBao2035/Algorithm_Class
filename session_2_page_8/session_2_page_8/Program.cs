using System.Diagnostics;

namespace session_2_page_8
{
     class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            Student[] listStudents = new Student[N];

            RanDomInformation(listStudents);

            displayAllStudents(listStudents);

            Stopwatch watch = new Stopwatch();

            watch.Start();
            totalScoreStudents(listStudents);
            watch.Stop();

            long time = watch.ElapsedMilliseconds;

            Console.WriteLine("Timer: {0} ms", time.ToString());

            void RanDomInformation(Student[] list)
            {
                Random rd = new Random();
                for(int i=0; i<list.Length; i++)
                {
                    string id  = "SV-" + rd.Next(1000);
                    int m1 = rd.Next(0,100);
                    int m2 = rd.Next(0,100);
                    int m3 = rd.Next(0,100);
                    list[i] = new Student(id, m1, m2, m3);
                }

            }
            void displayAllStudents(Student[] list)
            {
                for (int i = 0; i < list.Length; i++)
                {
                    list[i].display();
                    Console.WriteLine("----------------------");
                }
            }
            void totalScoreStudents(Student[] list)
            {
                double result = 0;
                for(int i=0; i<list.Length; i++)
                {
                    result += list[i].totalScored();
                }
                Console.WriteLine("[Part 1]: Total All Score Students: " + result/list.Length);
            }
        }
    }
}
