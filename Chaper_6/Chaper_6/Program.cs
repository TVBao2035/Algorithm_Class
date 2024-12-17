using Chaper_6.Main;
using System;

namespace Chaper_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree binSearchTree = new BinarySearchTree();
            int[] array = { 2, 3, 5, 1, 0, 9, 6, 7, 8, 4 };
            foreach (int num in array) binSearchTree.AddNode(num);


            App a = new App(binSearchTree);

        }
    }
}
