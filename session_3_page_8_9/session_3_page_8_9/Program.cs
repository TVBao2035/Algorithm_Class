namespace session_3_page_8_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void swap<T> (ref T objectA, ref T objectB)
            {
                T temp = objectA;
                objectA = objectB;
                objectB = temp;
            }
            static void display<T> (ref T objectA, ref T objectB)
            {
                Console.WriteLine("Object A = {0}, B = {1}.", objectA, objectB);
            }



            int a = 9, b = 1;
            display<int>(ref a, ref b);
            swap<int>(ref a, ref b);
            display<int>(ref a, ref b);
            string sA = "ABC", sB = "DEF";
            display<String>(ref sA, ref sB);
            swap<String>(ref sA, ref sB);
            display<String>(ref sA, ref sB);




            NhanVien nvA = new NhanVien("Nguyen Van A", "NV-001", 2);
            NhanVien nvB = new NhanVien("Nguyen Van B", "NV-002", 1);

            nvA.display();
            nvB.display();
            swap<NhanVien>(ref nvA, ref nvB);
            nvA.display();
            nvB.display();


            SinhVien svA = new SinhVien("Sinh Vien A", "SV_001", 5.5);
            SinhVien svB = new SinhVien("Sinh Vien B", "SV_002", 6.5);

            svA.display();
            svB.display();
            swap<SinhVien>(ref svA, ref svB);
            Console.WriteLine();
            svA.display();
            svB.display();
        }
    }
}
