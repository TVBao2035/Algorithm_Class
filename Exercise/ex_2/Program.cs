namespace ex_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 45, 23, 78, 67, 12, 88, 88, 34, 56, 92, 34 };

            // CAU A:
            Console.WriteLine("CAU A:");
            if (!Helper.checkCreaseArray(arr))
            {
                Sort.HeapSort(arr);
                Helper.display(arr);
            }

            // CAU B:
            Console.WriteLine("CAU B:");
            int x, k;
            Console.Write("Nhap X = ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Nhap K = ");
            k = int.Parse(Console.ReadLine());

            Helper.display(Helper.Insert(arr, x, k));

            // CAU C:
            Console.WriteLine("CAU C:");
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                if (Helper.IsNguyenTo(arr[i]))
                {
                    Console.WriteLine(BinarySearch.Search(arr, arr[i]));
                }

            }

            // CAU D:
            Console.WriteLine("CAU D:");
            int maxElement = arr[n - 1] + 1;
            int[] newArr = new int[maxElement];
            foreach (int e in arr)
            {
                newArr[e]++;
            }

            for (int i=0; i<maxElement; i++)
            {
                if (newArr[i] != 0) Console.WriteLine($" [{i}]: {newArr[i]}"); 
            }


        }
    }
}
