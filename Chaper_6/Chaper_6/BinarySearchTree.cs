using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaper_6
{
    internal class BinarySearchTree
    {
        public Node? root;

        public BinarySearchTree()
        {
            root = null;
        }

        public int CalculatorTreeHeight(Node node)
        {
            if (node == null) return -1;

            int leftTreeHeight = CalculatorTreeHeight(node.left);
            int rightTreeHeight = CalculatorTreeHeight(node.right);
            return (leftTreeHeight > rightTreeHeight ? leftTreeHeight : rightTreeHeight) + 1; 
        }
        public void CountAndSumAllNode(Node node, ref int count, ref int sum)
        {
            if(node != null)
            {
                count++;
                sum += node.value;
                CountAndSumAllNode(node.left, ref count, ref sum);
                CountAndSumAllNode(node.right, ref count, ref sum);
            }
        }
        public Node Search(int x)
        {
            Node currNode = root;
            while(currNode != null)
            {
                if (currNode.value == x) return currNode;
                if (currNode.value < x) currNode = currNode.right;
                else currNode = currNode.left;
            }
            return null;
        }
        public int findMin(Node node)
        {
            if (node.left == null) return node.value;
            return findMin(node.left);
        }
        public int findMax(Node node)
        {
            if (node.right == null) return node.value;
            return findMax(node.right);
        }


        public void Process(Node node)
        {
            if (node == null) Console.Write("null ");
            else Console.Write(node.value + " ");
        }

        public void PrevirousOrder(Node node)
        {
            if(node != null)
            {
                Process(node);
                PrevirousOrder(node.left);
                PrevirousOrder(node.right);
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

        public void PostOrder(Node node)
        {
            if(node != null)
            {
                PostOrder(node.left);
                PostOrder(node.right);
                Process(node);
            }
        }
        public bool Remove(int value)
        {
            if (root == null) return false;
            Node currNode = root;
            Node parentNode = root;
            bool isLeftSideNode = true;
            while(currNode.value != value)
            {
                parentNode = currNode;
                if(currNode.value < value)
                {
                    currNode = currNode.right;
                    isLeftSideNode = false;

                }
                else
                {
                    currNode = currNode.left;
                    isLeftSideNode = true;
                }
            }

            if(currNode.left == null && currNode.right == null)
            {
                if (currNode == root) root = null;
                else if (isLeftSideNode) parentNode.left = null;
                else parentNode.right = null;
                return true;
            }

            if(currNode.left == null)
            {
                if (root == currNode) root = currNode.right;
                else if (isLeftSideNode) parentNode.left = currNode.right;
                else parentNode.right = currNode.right;
                return true;
            }

            if(currNode.right == null)
            {
                if (root == currNode) root = currNode.left;
                else if (isLeftSideNode) parentNode.left = currNode.left;
                else parentNode.right = currNode.left;
                return true;
            }

            Node subNode = SubsNode(currNode);
            if (root == currNode) root = subNode;
            else if (isLeftSideNode) parentNode.left = subNode;
            else parentNode.right = subNode;
            subNode.left = currNode.left;
            return true;

        }
        public Node SubsNode(Node removeNode)
        {
            Node parentSubsNode = removeNode;
            Node subsNode = removeNode;
            Node currNode = removeNode.right;
            while(currNode != null)
            {
                parentSubsNode = subsNode;
                subsNode = currNode;
                currNode = currNode.left;
            }

            if(subsNode.value != removeNode.right.value)
            {
                parentSubsNode.left = subsNode.right;
                subsNode.right = removeNode.right;
            }

            return subsNode;
        }

        public bool AddNode(int value)
        {
            Node newNode = new Node(value);

            if (root == null)
            {
                root = newNode;
                return true;
            }

            Node currNode = root;
            Node parentNode;
            while (true)
            {
                parentNode = currNode;
                if (currNode.value == value) return false;

                if(currNode.value > value)
                {
                    currNode = currNode.left;
                    if(currNode == null)
                    {
                        parentNode.left = newNode;
                        return true;
                    }
                    continue;
                }

                if(currNode.value < value)
                {
                    currNode = currNode.right;
                    if(currNode == null)
                    {
                        parentNode.right = newNode;
                        return true;
                    }
                    continue;
                }
            }
        }
    }
}
