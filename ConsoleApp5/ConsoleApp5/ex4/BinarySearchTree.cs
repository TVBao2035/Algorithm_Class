using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.ex4
{
    internal class BinarySearchTree
    {
        public Node root;
        public BinarySearchTree()
        {
            root = null;
        }
        public Node SecondMaxNode()
        {
            if (root == null) return null;
            if (root.right == null) return root.left;
            Node curr = root;
            int max = root.value;
            Node parent = root;
            while(curr.right != null)
            {
                parent = curr;
                curr = curr.right;
            }
            if (curr.left != null) return curr.left;
            return parent;
        }
        public void AddNode(int value)
        {
            if(root == null)
            {
                root = new Node(value);
                return;
            }

            Node curr = root;
            Node parent;
            while(curr != null)
            {
                parent = curr;
                if (curr.value == value) return;

                if(curr.value > value)
                {
                    curr = curr.left;
                    if(curr == null)
                    {
                        parent.left = new Node(value);
                        return;
                    }
                    
                }else
                {
                    curr = curr.right;
                    if (curr == null)
                    {
                        parent.right = new Node(value);
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

        public void InsideOrder(Node node)
        {
            if(node != null)
            {
                InsideOrder(node.left);
                Process(node);
                InsideOrder(node.right);
            }
        }
    }
}
