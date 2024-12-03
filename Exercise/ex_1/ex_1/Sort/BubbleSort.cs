using ex_1.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1.Sort
{
    internal class BubbleSort
    {
        public static void Run(List<SinhVien> sv)
        {
            Console.WriteLine("Bubble Sort");
            for(int i = sv.Count - 1; i >= 0; i--)
            {
                for(int j = 0; j < i; j++)
                {
                    if (sv[j].score > sv[j + 1].score)
                    {
                        SinhVien temp = sv[j];
                        sv[j] = sv[j + 1];
                        sv[j + 1] = temp;
                    }
                }
            }
        }
    }
}
