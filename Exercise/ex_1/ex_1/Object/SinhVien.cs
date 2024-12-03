using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1.Object
{
    internal class SinhVien
    {
        public int id { get; set; }
        public string name { get; set; }
        public double score { get; set; }

        public SinhVien(int id, string name, double score)
        {
            this.id = id;
            this.name = name;
            this.score = score;
        }
        public SinhVien()
        {
            Console.Write("Enter Id : ");
            this.id = int.Parse(Console.ReadLine());
            
            Console.Write("Enter Name: ");
            this.name = Console.ReadLine();

            Console.Write("Enter Score: ");
            this.score = double.Parse(Console.ReadLine());
        }


        public void Display()
        {
            Console.WriteLine("#########################");
            Console.WriteLine($"Id :{this.id}");
            Console.WriteLine($"Name: {this.name}");
            Console.WriteLine($"Score:{this.score}");
        }
    }
}
