using System.Diagnostics;

namespace session_4_page_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            SinhVien[] arraySV = new SinhVien[n];
            List <SinhVien> listSV = new List<SinhVien>();



            void migrationInfor(SinhVien[] list)
            {
                for (int i = 0; i < list.Length; i++)
                {
                    list[i] = new SinhVien("SV-00" + (1 + i), "Sinh Vien " + (1 + i));
                }
            }

            void migrationInforByList(List<SinhVien> list, int n)
            {
                
                for (int i = 0; i < n; i++)
                {
                    
                    list.Add(new SinhVien("SV-00" + (1 + i), "Sinh Vien " + (1 + i)));
                }
            }
            
            Stopwatch timer = new Stopwatch();

            
            timer.Start();
            migrationInfor(arraySV);
            for (int i = 0; i < arraySV.Length; i++)
            {
                arraySV[i].display();
            }
            timer.Stop();

            long time1 = timer.ElapsedMilliseconds;
           
            Stopwatch timer2 = new Stopwatch();
            timer2.Start();
            migrationInforByList(listSV, n);
            for (int i = 0; i < listSV.Count; i++)
            {
                listSV[i].display();
            }
            timer2.Stop();
            long time2 = timer2.ElapsedMilliseconds;

            Console.WriteLine("TImer 1: {0}ms\nTimer 2: {1}ms", time1, time2);
        }
    }
}
