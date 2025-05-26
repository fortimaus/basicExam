using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmics
{
    class MyHT
    {
        string[] words;
        int size;
        int count;
        public MyHT(int size)
        {
            words = new string[size];
            this.size = size;
            count = 0;
        }
        private int hash(string value)
        {
            return value.Select(x => (int)x).Sum() % size;
        }
        private int hash2(string value)
        {
            return 7 - (value.Length % 7);
        }

        public bool insert(string value)
        {
            if (count == size)
                return false;
            int index = hash(value);
            int step = hash2(value);
            int i = 0;
            while (words[index] != null)
            {
                index = (hash(value) + i * step) % size;
                i++;
            }
            words[index] = value;
            count++;
            return true;
        }
        public string get(string value)
        {
            
            int index = hash(value);
            int step = hash2(value);
            int start = index;
            int i = 0;
            while (words[index] != null)
            {
                if (words[index].Equals(value))
                    return words[index];
                index = (hash(value) + i * step) % size;
                i++;
                if (index == start)
                    break;
            }
            return "Not found";
        }
        public void print()
        {
            for (int i = 0; i < words.Length; i++)
                Console.WriteLine($"{i}: {words[i]}");
        }
    }
}
