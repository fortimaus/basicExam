using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmics
{
    class DFS
    {
        public int v;
        public int[,] vertexs;
        public DFS(int v)
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

            for (int i = 0; i < v; i++)
            {
                Console.Write(i + "|" + "\t");
                for (int j = 0; j < v; j++)
                {
                    Console.Write(vertexs[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("__________");
        }
        public void search(int start, bool[] visited)
        {

            Console.Write(start + " - ");
            visited[start] = true;

            for (int i = 0; i < v; i++)
            {
                if (vertexs[start, i] == 1 && !visited[i])
                {
                    search(i, visited);
                    Console.WriteLine();
                }
            }

        }

    }
}
