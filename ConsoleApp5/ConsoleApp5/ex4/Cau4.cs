using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.ex4
{
    internal class Cau4
    {
        public Cau4()
        {
            int[] arr = { 10, 6, 15, 12, 9, 12, 26, 14, 56, 35 };
            BinarySearchTree bnt = new BinarySearchTree();
            foreach (int num in arr) bnt.AddNode(num);

            bnt.InsideOrder(bnt.root);

            Node res = bnt.SecondMaxNode();
            if (res != null)
                Console.WriteLine("The Second Max Node: " + res.value);
            else Console.WriteLine("not found");
        }
    }
}
