using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.Cau4
{
    internal class BinarySearchTree
    {
        public Node root;
        public BinarySearchTree()
        {
            root = null;
        }

        public void CountLeavesNode(Node node, ref int count)
        {
            if(node != null)
            {
                if (node.left == null && node.right == null) count++;
                CountLeavesNode(node.left, ref count);
                CountLeavesNode(node.right, ref count);
            }
        }
        public void InsideOrder(Node node)
        {
            if(node != null)
            {
                InsideOrder(node.left);
                Process(node);
                InsideOrder(node.right);
            }
        }
        public void AddNode(int x)
        {
            if(root == null)
            {
                root = new Node(x);
                return;
            }
            Node curr = root;
            Node parent = root;
            while (true)
            {
                parent = curr;
                if (curr.value == x) return;
                if(curr.value < x)
                {
                    curr = curr.right;
                    if(curr == null)
                    {
                        parent.right = new Node(x);
                        return;
                    }
                }
                else if(curr.value > x)
                {
                    curr = curr.left;
                    if(curr == null)
                    {
                        parent.left = new Node(x);
                        return;
                    }
                }
               
            }
        }
        public void Process(Node node)
        {
            if (node == null) Console.Write("NULL ");
            else Console.Write(node.value + " ");
        }
    }
}
