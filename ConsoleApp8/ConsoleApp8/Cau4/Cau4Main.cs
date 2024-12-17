using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.Cau4
{
    internal class Cau4Main
    {
        public Cau4Main()
        {
            int[] array = { 10, 6, 15, 12, 9, 12, 26, 14, 56, 35 };
            
            BinarySearchTree binarysearchTree = new BinarySearchTree();

            foreach (int num in array)
            {  
                binarysearchTree.AddNode(num);
            }
                  

            binarysearchTree.InsideOrder(binarysearchTree.root);
            int countLeavesNode = 0;
            binarysearchTree.CountLeavesNode(binarysearchTree.root, ref countLeavesNode);
            Console.WriteLine("\nSo node la: " + countLeavesNode);

        }
    }
}
