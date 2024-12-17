
namespace ex_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 29, 11, 44, 38, 50, 39, 52, 42, 49 };
            LinkList linkList = new LinkList();
            foreach (int num in array) linkList.AddAfter(num);

            linkList.print();
            Node minEvenNode = linkList.findMinEvenNode();

            if (minEvenNode != null)
            {
                Console.WriteLine(minEvenNode.value);
            }
            else Console.WriteLine("Not Found");

            linkList.addAfterNode(100, minEvenNode);
            linkList.print();
            Console.WriteLine(linkList.sumAverageAllOddNode());
        }

      
    }
}
