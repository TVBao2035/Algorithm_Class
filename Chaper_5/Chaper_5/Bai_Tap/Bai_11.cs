using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaper_5.Bai_Tap
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Product (int id, string name)
        {
            Id = id;
            Name = name;
        }
        public Product()
        {
            Console.WriteLine("Nhap Id");
            Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Name: ");
            Name = Console.ReadLine();
        }

        public void print()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}");
        }
    }
    class Store
    {
        List<Product> list;
        public Store()
        {
            list = new List<Product>();
        }

        public bool Empty()
        {
            return list.Count == 0;
        }

        public void Enqueue(Product p)
        {
            list.Add(p);
        }

        public Product Dequeue()
        {
            Product temp = list[0];
            list.RemoveAt(0);
            return temp;
        }

        public Product Peek()
        {
            return list[0];
        }

        public void Clear()
        {
            list.Clear();
        }

        public int Size()
        {
            return list.Count;
        }
    }
    internal class Bai_11
    {

        private Store store = new Store();
        public Bai_11()
        {
            
            while (true) Menu();
        }
        public void Menu()
        {
            Console.Clear();
            int option;
            do
            {
                Console.WriteLine("[1]. Nhap Hang");
                Console.WriteLine("[2]. Xuat Hang");
                Console.WriteLine("[3]. Xuat Mot Don Hang");
                Console.WriteLine("[4]. Xem So Luong Lo Hang Trong Kho");
                Console.WriteLine("Nhap Lua Chong: ");
                option = int.Parse(Console.ReadLine());

            } while (option < 1 || option > 4);
            Console.Clear();
            switch (option)
            {

                case 1:
                    ImportProduct();
                    Console.ReadKey();
                    break;
                case 2:
                    ExportProduct();
                    Console.ReadKey();
                    break;
                case 3:
                    ExportOneProduct();
                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine($"So Luong Lo Hang Ton Tai {store.Size()}");
                    Console.ReadKey();
                    break;

            }
        }
        public void ExportOneProduct()
        {
            if (store.Empty())
            {
                Console.WriteLine("Het Hang");
                return;
            }

            store.Dequeue().print();
        }
        public void ExportProduct()
        {
            Console.WriteLine("Nhap So Luong Lo Hang Can Xuat: ");
            int n = int.Parse(Console.ReadLine());
            for(int i=0; i<n; i++)
            {
             
                if (store.Empty())
                {
                    Console.WriteLine("Het Hang");
                    break;
                }
                Console.WriteLine("Xuat Lo Hang");
                store.Dequeue().print();
            }
        }

        public void ImportProduct()
        {
            Console.WriteLine("Nhap So Luong Lo Hang: ");
            int n = int.Parse(Console.ReadLine());
            for(int i=0; i<n; i++)
            {
                store.Enqueue(new Product());
            }
        }
    }
}
