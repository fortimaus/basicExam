using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmics
{
    class BFS
    {
        public int v;
        public int[,] vertexs;
        public BFS(int v)
        {
            this.v = v;
            vertexs = new int[v, v];
            for (int i = 0; i < v; i++)
                for (int j = 0; j < v; j++)
                    vertexs[i, j] = 0;
        }

        public void insert(int v1, int v2)
        {
            if (v1 == v2)
                return;
            vertexs[v1, v2] = 1;
            vertexs[v2, v1] = 1;
        }
        public void print()
        {
            Console.Write("v\t");
            for (int i = 0; i < v; i++)
                Console.Write(i + "\t");
            Console.WriteLine();

            for (int i = 0; i < v; i++)
                Console.Write("________");

            Console.WriteLine();
            
            for(int i = 0; i < v; i++ )
            {
                Console.Write(i + "|"+ "\t");
                for(int j = 0; j < v; j++)
                {
                    Console.Write(vertexs[i,j] + "\t");
                }
                Console.WriteLine();
            }

        }
        public void search(int start)
        {
            bool[] visited = new bool[v];
            List<int> fifo = new List<int>();
            
            fifo.Add(start);
            visited[start] = true;
            
            int curV; 
            
            while(fifo.Count != 0)
            {
                curV = fifo[0];
                Console.WriteLine("__________");
                Console.WriteLine(curV);

                fifo.Remove(curV);

                for(int i = 0; i < v; i++)
                {
                    if (vertexs[curV,i] == 1 && !visited[i])
                    {
                        Console.Write(i + "\t");
                        fifo.Add(i);
                        visited[i] = true;
                        
                    }
                }
                Console.WriteLine();
                Console.WriteLine("__________");
            }
        }
    }

}
