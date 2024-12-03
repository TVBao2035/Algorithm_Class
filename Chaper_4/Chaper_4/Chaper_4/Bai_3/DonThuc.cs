using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaper_4.Bai_3
{
    internal class DonThuc
    {
        public int Co_So { get; set; }
        public int So_Mu { get; set; }

        public DonThuc(int cs, int sm)
        {
            Co_So = cs;
            So_Mu = sm;
        }
        public DonThuc()
        {
            Console.Write("Nhap Co So: ");
            Co_So = int.Parse(Console.ReadLine());
            Console.Write("Nhap So Mu: ");
            So_Mu = int.Parse(Console.ReadLine());
        }

        public void print()
        {
            Console.Write($"{Co_So}X^{So_Mu}");
        }
    }
}
