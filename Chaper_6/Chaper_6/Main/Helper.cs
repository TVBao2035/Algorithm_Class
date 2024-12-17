using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaper_6.Main
{
    internal class Helper
    {
        public Helper()
        {

        }

        public static bool RemoveOrtherWay( BinarySearchTree bst, Node parentNode, Node currNode, int x, bool isLeft)
        {
            

            if (currNode == null) return false;
           
            if (currNode.value > x) return RemoveOrtherWay( bst, currNode, currNode.left, x, true);
         
            if (currNode.value < x) return  RemoveOrtherWay( bst, currNode, currNode.right, x,false);
            if(currNode.value == x)
            {
               
                if(currNode.left == null && currNode.right == null)
                {
                    if (bst.root == currNode) bst.root = null;
                    else if (isLeft) parentNode.left = null;
                    else parentNode.right = null;
                    return true;
                }
                if(currNode.left == null)
                {
                    if (bst.root == currNode) bst.root = currNode.right;
                    else if (isLeft) parentNode.left = currNode.right;
                    else parentNode.right = currNode.right ;
                    return true;
                }
                if (currNode.right == null)
                {
                    if (bst.root == currNode) bst.root = currNode.left;
                    else if (isLeft) parentNode.left = currNode.left;
                    else parentNode.right = currNode.left;
                    return true;
                }
                Node sub = bst.SubsNode(currNode);
                if (bst.root == currNode) bst.root = sub;
                else if (isLeft) parentNode.left = sub;
                else parentNode.right = sub;
                sub.left = currNode.left;
                return true;
            }
            return false;
        }
        public static int LevelOfNode(Node node, int x)
        {
            if (node == null) return -1;
            if (node.value == x) return 0;
            int leftHeightTree = LevelOfNode(node.left,  x);
            int rightHeightTree = LevelOfNode(node.right, x);

            return (leftHeightTree > rightHeightTree ? leftHeightTree : rightHeightTree) + 1;
        }
        public static void SumAllLeavesNode(Node node, ref int sum)
        {
            if(node != null)
            {
                if (node.left == null && node.right == null) sum += node.value;
                SumAllLeavesNode(node.left, ref sum);
                SumAllLeavesNode(node.right, ref sum);
            }
        }
        public static void CountNodesHasOneChild(Node node, ref int count)
        {
            if (node != null)
            {
                if (node.left != null && node.right == null)
                {
                    count++;
                }
                if(node.left == null && node.right != null)
                {
                    count++;
                }
                CountNodesHasOneChild(node.left, ref count);
                CountNodesHasOneChild(node.right, ref count);
            }
        }
        public static void CoundBiggerZero(Node node, ref int count)
        {
            if (node != null)
            {
                if (node.value >= 0) count++;
                CoundBiggerZero(node.left, ref count);
                CoundBiggerZero(node.right, ref count);
            }
        }
        public static void CoundOddNode(Node node, ref int count)
        {
            if(node != null)
            {
                if (node.value % 2 == 0) count++;
                CoundOddNode(node.left, ref count);
                CoundOddNode(node.right, ref count);
            }
        }
        public static void CountLeavesNode(Node node, ref int count)
        {
            if(node != null)
            {
                if (node.left == null && node.right == null) count++;

                CountLeavesNode(node.left,ref count);
                CountLeavesNode(node.right, ref count);
            }
        }
        public static Node SearchTheMostMinNodeAndBiggerNodeX(BinarySearchTree b, int x)
        {
            Node curr = b.root;
            Node res = b.root;
            bool check = false;
            while (curr != null)
            {
                if (res.value > curr.value && curr.value > x)
                {
                    res = curr;
                    check = true;
                }

                if (curr.value < x) curr = curr.right;
                else curr = curr.left;
            }
            return check ? res : null;
        }
        public static Node SearchTheMostMaxNodeAndSmallerNodeX(BinarySearchTree b, int x)
        {
            Node curr = b.root;
            Node res = b.root;
            bool check = false;
            while(curr != null)
            {
                if(res.value < curr.value && curr.value < x)
                {
                    res = curr;
                    check = true;
                }

                if (curr.value < x) curr = curr.right;
                else curr = curr.left;
            }
            return check ? res : null;
        }
         public static Node SearchOrderWay(Node node, int x)
        {
            if (node == null) return null;
            if (node.value == x) return node;
            if (node.value < x) return SearchOrderWay(node.right, x);
            return SearchOrderWay(node.left, x);

        }

        public static bool AddNodeOrtherWay(Node root, int x)
        {
            if (root == null) return false;
            if (root.value == x) return false;
            if (root.value < x)
            {
                if (root.right == null)
                {
                    root.right = new Node(x);
                    return true; ;
                }
                AddNodeOrtherWay(root.right, x);
            }
            else
            {
                if (root.left == null)
                {
                    root.left = new Node(x);
                    return true;
                }
                AddNodeOrtherWay(root.left, x);
            }
            return false;
        }
    }
}
