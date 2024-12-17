using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_3
{
    internal class LinkList
    {
        public Node root;
        public LinkList()
        {
            root = null;
        }

        public void print()
        {
            if (root == null) Console.Write("null");
            Node curr = root;
            while(curr != null)
            {
                Console.Write(curr.value);
                if(curr.next != null)
                {
                    Console.Write("->");
                }
                curr = curr.next;
            }
            Console.WriteLine();
        }

        public void AddAfter(int value)
        {
            Node newNode = new Node(value);
            if(root == null)
            {
                root = newNode;
                return;
            }
            Node curr = root;
            
            while(curr.next != null)
            {
                curr = curr.next;
            }
            curr.next = newNode;
        }
        public double sumAverageAllOddNode()
        {
            if (root == null) return 0;
            int sum = 0;
            int count = 0;
            Node curr = root;
            while(curr != null)
            {
                if((int)curr.value %2 != 0)
                {
                    count++;
                    sum += (int)curr.value;
                }
                curr = curr.next;
            }
            return sum * 1.0 / count;
        }

        public Node findMinEvenNode()
        {
            if (root == null) return null;
            bool check = false;
            Node curr = root;
            Node minEvenNode = null;
            while (curr != null)
            {
                if ((int)curr.value % 2 == 0)
                {
                    minEvenNode = curr;
                    break ;
                }
                curr = curr.next;
            }
            if (minEvenNode == null) return null;
            while (curr != null)
            {
                if((int) curr.value % 2 == 0 &&(int) curr.value  < (int) minEvenNode.value)
                {
                    minEvenNode = curr;
                }
                curr = curr.next;
            }

             return minEvenNode;
        }

        public bool addAfterNode(int value, Node node)
        {
            if (root == null) return false;
            Node curr = root;
            Node newNode = new Node(value);


            while(curr != null)
            {
                if((int)curr.value == (int)node.value)
                {
                    newNode.next = curr.next;
                    curr.next = newNode;
                    return true;
                }
                curr = curr.next;
            }
            return false;

        }
    }
}
