using System.Diagnostics;

namespace session_1_page_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter The Length Of Array: ");
            long lengthOfArray = Convert.ToInt64(Console.ReadLine());
            long[] array = new long[lengthOfArray];
            for(long i=0; i<lengthOfArray; i++)
            {
                array[i] = i;
            }

            Stopwatch timer = new Stopwatch();
            timer.Start();

            displayArray(array);

            timer.Stop();

            long result = timer.ElapsedMilliseconds;
            Console.WriteLine();
            Console.WriteLine("==>> Result: " + result + "ms");
            int minutes = 0;
            result = result / 1000;
            while(result > 60)
            {
                minutes++;
                result /= 60;
            }
            Console.WriteLine("==>> {0}:{1}", minutes.ToString("0#"), result.ToString("0#"));
            void displayArray(long[] array)
            {
                int count = 0;
                int max = 25;
                for(long i=0; i<array.Length; i++)
                {
                    if(count++ == max && array.Length < 100000)
                    {
                        Console.WriteLine();
                        count = 0;
                    }
                    Console.Write(array[i] + " ");
         
                }
            }
        }
    }
}
