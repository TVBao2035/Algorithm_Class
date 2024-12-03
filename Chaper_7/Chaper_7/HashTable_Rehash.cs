using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaper_7
{
    internal class HashTable_Rehash
    {
        public static int M = 10;
        public static int P = 7;
        public static int Type = 1;
        public Element[] Table;

        public HashTable_Rehash()
        {
            Table = new Element[M];
            for(int i=0; i<M; i++) Table[i] = null;
        }

        public int hashFunction(int key)
        {
            return key % M;
        }

        public int doubleHastFunciton(int key)
        {
            return 1 + (key % P);
        }


        public int rehashFunciton(int key, int index)
        {
            int h0 = hashFunction(key);
            int hi = h0;
            switch (Type)
            {
                case 1:
                    hi = (h0 + index) % M;
                    break;
                case 2:
                    hi = (h0 + (index * index)) % M;
                    break;
                case 3:
                    int dh = doubleHastFunciton(key);
                    hi = (h0 + (dh * index)) % M;
                    break;
            }

            return hi;
        }
        public void AddElement(int key, int value)
        {
            int h0 = hashFunction(key);
            int index = 0;
            int currentIndex = h0;

            while (Table[currentIndex] != null && Table[currentIndex].Key != key)
            {
                index++;
                currentIndex = rehashFunciton(key, index);
            }
            Table[currentIndex] = new Element(key, value);
        }

        public void AddManyElements(int[] keys, int[] values)
        {
            for(int i=0; i<keys.Length; i++)
            {
                AddElement(keys[i], values[i]);
            }
        }

        public int GetValue(int key)
        {
            int h0 = hashFunction(key);
            int index = 0;
            int currentIndex = h0;

            while (Table[currentIndex] != null && Table[currentIndex].Key == key)
            {
                index++;
                currentIndex = rehashFunciton(key, index);
            }
            if (Table[currentIndex] == null) return -1;

            return Table[currentIndex].Value; 
        }

        public void Display()
        {
            for(int i=0; i<M; i++)
            {
                Console.Write("Address: " + i + ": ");
                if (Table[i] == null)
                {
                    Console.WriteLine("null");
                    continue;
                }
                Console.WriteLine($"key = {Table[i].Key}; value = {Table[i].Value}");
            }
        }
    }
}
