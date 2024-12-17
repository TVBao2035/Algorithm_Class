using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.ex2
{
    internal class LinkedList
    {
        public Node root;
        public LinkedList()
        {
            root = null;
        }

        public double sumOfAverage()
        {
            if (root == null) return 0.0;
            int count = 0;
            int sum = 0;
            Node curr = root;
            while(curr != null)
            {
                if((int)curr.value > 30 && (int) curr.value < 50)
                {
                    count++;
                    sum += (int)curr.value;
                }
                curr = curr.next;
            }
            return count==0? 0.0 : (sum * 1.0) / count;
        }
        public void AddNode(Object x)
        {
            if(root == null)
            {
                root = new Node(x);
                return;
            }
            Node curr = root;
            while (curr != null)
            {
                if(curr.next == null)
                {
                    curr.next = new Node(x);
                    return;
                }
                curr = curr.next;
            }
            
        }
        public void print()
        {
            Node curr = root;
            while(curr != null)
            {
                Console.Write(curr.value);
                if (curr.next != null) Console.Write(" -> ");
                curr = curr.next;
            }
        }
    }
}
