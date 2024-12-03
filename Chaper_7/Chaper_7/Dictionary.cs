using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Collections;
using static System.Net.Mime.MediaTypeNames;    
namespace Chaper_7
{
    internal class Dictionary
    {
        string textFile = @"Dictionary.txt";
       
        // HashTable_Rehash hash = new HashTable_Rehash();
        Hashtable hash = new Hashtable();
        public Dictionary() {
            string key, value;
           if (File.Exists(textFile)) {
               // Read entire text file content in one string
               string[] text = File.ReadAllLines(textFile);
               for(int i=0; i<text.Length; i++)
               {
                   key = text[i].Split('#')[1];
                   value = text[i].Split('#')[0];
                   hash.Add(key, value);
               }
                while (true)
                {
                    Console.Clear();
                    int option;
                    do
                    {
                        Console.WriteLine("[1].Add");
                        Console.WriteLine("[2].Search");
                        Console.Write("Enter Option: ");
                        option = int.Parse(Console.ReadLine());
                    } while (option < 1 || option > 2);
                    Console.Clear();
                    switch (option)
                    {
                        case 1:
                            add();
                            Console.ReadKey();
                            break;
                        case 2:
                            search();
                            Console.ReadKey();
                            break;
                    }
                }
                

           }
        
        }
        public void add()
        {
            Console.WriteLine("Nhap TA:");
            string key = Console.ReadLine();
            Console.WriteLine("Nhap TV:");
            string value =  Console.ReadLine();
            hash.Add(value, key);
            File.AppendAllText(textFile, Environment.NewLine + $"{key}#{value}");
            Console.WriteLine(File.ReadAllText(textFile));
        }


        public void search()
        {
            Console.WriteLine("Nhap TA:");
            string world = Console.ReadLine();
            foreach (var val in hash.Keys)
            {
                if (hash[val].Equals(world))
                {
                    Console.WriteLine(val);
                }
            }
        }

}
}
