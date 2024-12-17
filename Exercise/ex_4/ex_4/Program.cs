namespace ex_4
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            string text;
            Console.WriteLine("Enter your text:");
            text = Console.ReadLine();
            Console.WriteLine(Dao_Chuoi(text));

        }

        public static string Dao_Chuoi(string text)
        {
            Stack<char> stk = new Stack<char>();
            foreach (char c in text) stk.Push(c);

            string res = "";
            while (stk.Count != 0)
            {
                res += stk.Pop();
            }
            return res;
        }
    }
}
