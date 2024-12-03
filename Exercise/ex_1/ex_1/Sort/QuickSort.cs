using ex_1.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1.Sort
{
    internal class QuickSort
    {
        public static void Run(List<SinhVien> list)
        {
            Console.WriteLine("Quick Sort");
            Setting(list, 0, list.Count - 1);
        }

        public static void Setting(List<SinhVien> listSV, int left, int right)
        {
            
            int mid = (right + left) / 2;
            SinhVien saved = listSV[mid];
            int i = left;
            int j = right;
            while(i < j)
            {
                while (listSV[i].score > saved.score) i++;
                while (listSV[j].score < saved.score) j--;

                if(i <= j)
                {
                    SinhVien temp = listSV[i];
                    listSV[i] = listSV[j];
                    listSV[j] = temp;

                    i++;
                    j--;
                }

            }
             if (i < right) Setting(listSV, i, right);
             if (j > left) Setting(listSV, left, j);
        }
    }
}
