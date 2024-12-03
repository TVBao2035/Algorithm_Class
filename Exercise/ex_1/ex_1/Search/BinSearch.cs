using ex_1.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1.Search
{
    internal class BinSearch
    {
        public static SinhVien Run(List<SinhVien> list,SinhVien sv)
        {
            //List<SinhVien> res = new List<SinhVien>();
            Console.WriteLine(list.Count);
            int left = 0, right = list.Count - 1;

            while(left <= right)
            {
                int mid = (right + left) / 2;
                if(sv.score == list[mid].score)
                {
                    return list[mid];
                }

                if(sv.score < list[mid].score)
                {
                    right = mid - 1;
                }

                if (sv.score > list[mid].score) left = mid + 1;
            }

            return null;
        }
    }
}
