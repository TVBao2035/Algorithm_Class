using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.Cau2
{
    internal class Cau2Main
    {
        public Cau2Main()
        {
            int[] arr = { 17, 83, 8, 78, 6, 2, 78, 5, 83, 4 };
            LinkedList linkedList = new LinkedList();
            foreach (int num in arr) linkedList.addNode(num);

            linkedList.print();
            int Q, X;
            Console.WriteLine("\nNhap Q:");
            Q = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap X:");
            X = int.Parse(Console.ReadLine());
            linkedList.addBefore(Q, X);
            linkedList.print();

        }
    }
}
