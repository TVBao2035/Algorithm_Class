using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaper_4.Bai_1.Setup
{
    internal class LinkedList
    {
        public Node? first = new Node();

        public LinkedList()
        {
            first = null;
        }

        public int Count()
        {
            if (first == null) return 0;
            int count = 0;
            Node currNode = first;
            while(currNode != null)
            {
                count++;
                currNode = currNode.next;
            }
            return count;
        }

        public void Remove()
        {
            if (first == null) return;

            Node currNode = first;
            while (currNode.next.next != null)
            {
                currNode = currNode.next; 
            }
            currNode.next = null;
        }

        public void RemoveFirst()
        {
            if (first == null) return;

            Node node = first.next;
            first = node;
        }

        public void Add(Node node)
        {
            if (first == null)
            {
                first = node;
                return;
            }
            Node curr = first;
            while (curr.next != null)
            {
                curr = curr.next;
            }
            curr.next = node;
        }

        public void AddFirst(Node node)
        {
            if (first == null)
            {
                first = node;
                return;
            }

            node.next = first;
            first = node;
            return;
        }

        public void AddAfter(Node newNode, Node nodeX)
        {
            if (first == null || newNode == null || nodeX == null) return;

            Node currNode = first;
            while (currNode.next != null && !currNode.value.Equals(nodeX.value))
            {
                currNode = currNode.next;
            }
            if (currNode.value.Equals(nodeX.value))
            {
                newNode.next = currNode.next;
                currNode.next = newNode;
            }
        }

        public void AddBefore(Node newNode, Node nodeX)
        {
            if (first == null || newNode == null || nodeX == null) return;
            Node currNode = first;
            while(currNode.next != null)
            {
                if (currNode.next.value.Equals(nodeX.value))
                {
                    newNode.next = currNode.next;
                    currNode.next = newNode;
                    return;
                }

                currNode = currNode.next;
            }
        }
        
        public Node Find(Node nodeX)
        {
            if (first == null) return null;
            Node currNode = first;
            while (currNode != null)
            {
                if (currNode.value.Equals(nodeX.value)) return currNode;
                currNode = currNode.next;
            }

            return null;
        }

        public void Print()
        {
            if (first == null)
            {
                Console.WriteLine("List Is Empty");
                return;
            }

            Node current = first;
            while (current != null)
            {
                Console.Write($"{current.value}");
                if (current.next != null) Console.Write(" -> ");
                current = current.next;
            }
            Console.WriteLine();
        }
    }
}
