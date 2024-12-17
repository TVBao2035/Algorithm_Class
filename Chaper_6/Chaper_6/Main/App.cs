using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaper_6.Main
{
    internal class App
    {
        BinarySearchTree bst;
        public App(BinarySearchTree bst)
        {
            this.bst = bst;
            while (true)
            {
                Console.Clear();
                int option;
                do
                {
                    for(int i=1; i<=25; i++)
                    {
                        Console.WriteLine($"[{i}].Bai 1.2.{i}");
                    }
                    Console.WriteLine("Enter your option:");
                    try
                    {
                        option = int.Parse(Console.ReadLine());
                    }catch(Exception ex)
                    {
                        option = -1;
                        Console.WriteLine("You must enter a number");
                    }
                } while (option <= 0 || option > 25);

                Console.Clear();
                switch (option)
                {
                    case 1:
                        Bai_1_2_1();
                        Console.ReadKey();
                        break;
                    case 2:
                        Bai_1_2_2();
                        Console.ReadKey();
                        break;
                    case 3:
                        Bai_1_2_3();
                        Console.ReadKey();
                        break;
                    case 4:
                        Bai_1_2_4();
                        Console.ReadKey();
                        break;
                    case 5:
                        Bai_1_2_5();
                        Console.ReadKey();
                        break;
                    case 6:
                        Bai_1_2_6();
                        Console.ReadKey();
                        break;
                    case 7:
                        Bai_1_2_7();
                        Console.ReadKey();
                        break;
                    case 8:
                        Bai_1_2_8();
                        Console.ReadKey();
                        break;
                    case 9:
                        Bai_1_2_9();
                        Console.ReadKey();
                        break;
                    case 10:
                        Bai_1_2_10();
                        Console.ReadKey();
                        break;
                    case 11:
                        Bai_1_2_11();
                        Console.ReadKey();
                        break;
                    case 12:
                        Bai_1_2_12();
                        Console.ReadKey();
                        break;
                    case 13:
                        Bai_1_2_13();
                        Console.ReadKey();
                        break;
                    case 14:
                        Bai_1_2_14();
                        Console.ReadKey();
                        break;
                    case 15:
                        Bai_1_2_15();
                        Console.ReadKey();
                        break;
                    case 16:
                        Bai_1_2_16();
                        Console.ReadKey();
                        break;
                    case 17:
                        Bai_1_2_17();
                        Console.ReadKey();
                        break;
                    case 18:
                        Bai_1_2_18();
                        Console.ReadKey();
                        break;
                    case 19:
                        Bai_1_2_19();
                        Console.ReadKey();
                        break;
                    case 20:
                        Bai_1_2_20();
                        Console.ReadKey();
                        break;
                    case 21:
                        Bai_1_2_21();
                        Console.ReadKey();
                        break;
                    case 22:
                        Bai_1_2_22();
                        Console.ReadKey();
                        break;
                    case 23:
                        Bai_1_2_23();
                        Console.ReadKey();
                        break;
                    case 24:
                        Bai_1_2_24();
                        Console.ReadKey();
                        break;
                    case 25:
                        Bai_1_2_25();
                        Console.ReadKey();
                        break;

                }
            }

        }
        public void Bai_1_2_25()
        {
            Console.WriteLine("Bai 1.2.25");
            bst.InsideOrder(bst.root);
            Console.WriteLine("\nEnter X: ");
            int x = int.Parse(Console.ReadLine());
            bst.Remove(x);
            bst.InsideOrder(bst.root);

        }
        public void Bai_1_2_24()
        {
            Console.WriteLine("Bai 1.2.24");
            bst.InsideOrder(bst.root);
            Console.WriteLine("\nEnter X: ");
            int x = int.Parse(Console.ReadLine());
            Helper.RemoveOrtherWay(bst, bst.root, bst.root, x, true);
            bst.InsideOrder(bst.root);

        }
        public void Bai_1_2_23()
        {
            Console.WriteLine("Bai 1.2.23");
            bst.InsideOrder(bst.root);
           
            Console.WriteLine($"\nLevel Of Tree is {bst.CalculatorTreeHeight(bst.root)}");

        }
        public void Bai_1_2_22()
        {
            Console.WriteLine("Bai 1.2.22");
            bst.InsideOrder(bst.root);
            Console.WriteLine("\nEnter X: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine($"Level Of {x} is {Helper.LevelOfNode(bst.root, x)}");

        }
        public void Bai_1_2_21()
        {
            Console.WriteLine("Bai 1.2.21");
            bst.InsideOrder(bst.root);
            int sum = 0;
            Helper.SumAllLeavesNode(bst.root, ref sum);
            Console.WriteLine("\nSum All Value Of Leave Node: " + sum);
        }
        public void Bai_1_2_20()
        {
            Console.WriteLine("Bai 1.2.20");
            bst.InsideOrder(bst.root);
            int count = 0, sum = 0;
            bst.CountAndSumAllNode(bst.root, ref count, ref sum);
            Console.WriteLine("\nSum All Value Of Node: " + sum);
        }
        public void Bai_1_2_19()
        {
            Console.WriteLine("Bai 1.2.19");
            bst.InsideOrder(bst.root);
            int count = 0;
            Helper.CountNodesHasOneChild(bst.root, ref count);
            Console.WriteLine("\nNumber Of Nodes Has One Child: " + count);
        }
        public void Bai_1_2_18()
        {
            Console.WriteLine("Bai 1.2.18");
            bst.InsideOrder(bst.root);
            int count = 0;
            Helper.CoundBiggerZero(bst.root, ref count);
            Console.WriteLine("\nNumber Of Bigger Nodes Than Zero: " + count);
        }
        public void Bai_1_2_17()
        {
            Console.WriteLine("Bai 1.2.17");
            bst.InsideOrder(bst.root);
            int count = 0;
            Helper.CoundOddNode(bst.root, ref count);
            Console.WriteLine("\nNumber Of Odd Nodes: " + count);
        }
        public void Bai_1_2_16()
        {
            Console.WriteLine("Bai 1.2.16");
            bst.InsideOrder(bst.root);
            int count = 0;
            Helper.CountLeavesNode(bst.root, ref count);
            Console.WriteLine("\nNumber Of Leaves Nodes: " + count);
        }
        public void Bai_1_2_15()
        {
            Console.WriteLine("Bai 1.2.15");
            bst.InsideOrder(bst.root);
            int count = 0, sum = 0;
            bst.CountAndSumAllNode(bst.root, ref count,ref sum);
            Console.WriteLine("\nNumber Of Nodes: " +count );
        }
        public void Bai_1_2_14()
        {
            Console.WriteLine("Bai 1.2.14");
            bst.InsideOrder(bst.root);
            Console.WriteLine("\nEnter X: ");
            int x = int.Parse(Console.ReadLine());
            Node res = Helper.SearchTheMostMinNodeAndBiggerNodeX(bst, x);
            if (res != null) res.DisplayNode();
            else Console.WriteLine("Not Found");
        }
        public void Bai_1_2_13()
        {
            Console.WriteLine("Bai 1.2.13");
            bst.InsideOrder(bst.root);
            Console.WriteLine("\nEnter X: ");
            int x = int.Parse(Console.ReadLine());
            Node res = Helper.SearchTheMostMaxNodeAndSmallerNodeX(bst, x);
            if (res != null) res.DisplayNode();
            else Console.WriteLine("Not Found");
        }
        public void Bai_1_2_12()
        {
            Console.WriteLine("Bai 1.2.12");
            bst.InsideOrder(bst.root);

            Console.WriteLine("\nMin Node: " + bst.findMin(bst.root));
        }

        public void Bai_1_2_11()
        {
            Console.WriteLine("Bai 1.2.11");
            bst.InsideOrder(bst.root);

            Console.WriteLine("\nMax Node: " + bst.findMax(bst.root));
        }

        public void Bai_1_2_10()
        {
            Console.WriteLine("Bai 1.2.10");
            bst.InsideOrder(bst.root);
            Console.WriteLine("\nEnter X: ");
            int x = int.Parse(Console.ReadLine());
            Node res = bst.Search(x);
            if (res != null) res.DisplayNode();
            else Console.WriteLine("Not Found!");

        }
        public void Bai_1_2_9()
        {
            Console.WriteLine("Bai 1.2.9");
            bst.InsideOrder(bst.root);
            Console.WriteLine("\nEnter X: ");
            int x = int.Parse(Console.ReadLine());
            Node res = Helper.SearchOrderWay(bst.root, x);
            if (res != null) res.DisplayNode();
            else Console.WriteLine("Not Found!");

        }
        public void Bai_1_2_8()
        {
            int num;
            do
            {
                Console.WriteLine("Bai 1.2.8");
                Console.Clear();
                bst.InsideOrder(bst.root);
                Console.WriteLine("\n[0].Exit");
                Console.WriteLine("Enter new Node: ");
                try
                {
                    num = int.Parse(Console.ReadLine());
                    if (num != 0) bst.AddNode(num);
                }catch(Exception ex)
                {
                    Console.WriteLine("You must enter a number");
                    num = -1;
                }

            } while (num != 0);

            
        }
        public void Bai_1_2_7()
        {
            Console.WriteLine("Bai 1.2.7");
            Console.Write("Array: ");
            int[] array = { 2, 3, 5, 1, 0, 9, 6, 7, 8, 4 };
            foreach(int num in array)
            {
                bst.AddNode(num);
                Console.Write(num + " ");
            }
            Console.WriteLine("\nBinary Search Tree: ");
            bst.InsideOrder(bst.root);
        }
        public void Bai_1_2_6()
        {
            Console.WriteLine("Bai 1.2.6");
            Console.WriteLine("Post Ordering: ");
            bst.PostOrder(bst.root);
        }
        public void Bai_1_2_5()
        {
            Console.WriteLine("Bai 1.2.5");
            Console.WriteLine("Inside Ordering: ");
            bst.InsideOrder(bst.root);
        }

        public void Bai_1_2_4()
        {
            Console.WriteLine("Bai 1.2.4");
            Console.WriteLine("Previrous Ordering: ");
            bst.PrevirousOrder(bst.root);
        }
        public void Bai_1_2_3()
        {
            Console.WriteLine("Bai 1.2.3");
            Console.WriteLine("Enter X: ");
            int x = int.Parse(Console.ReadLine());
            bst.AddNode(x);
            bst.InsideOrder(bst.root);
        }

        public void Bai_1_2_2()
        {
            Console.WriteLine("Bai 1.2.2");
            Console.WriteLine("Enter X: ");
            int x = int.Parse(Console.ReadLine());
            Helper.AddNodeOrtherWay(bst.root, x);
            bst.InsideOrder(bst.root);
        }

        
        public void Bai_1_2_1()
        {
            Console.WriteLine("Bai 1.2.1");
            Console.WriteLine("Display Root Node:");
            bst.root.DisplayNode();
            
        }


       
    }
}
