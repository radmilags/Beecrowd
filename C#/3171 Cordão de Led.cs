using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int N = int.Parse(input[0]); 
        int L = int.Parse(input[1]); 

        List<int>[] graph = new List<int>[N + 1];
        for (int i = 0; i <= N; i++)
        {
            graph[i] = new List<int>();
        }

        for (int i = 0; i < L; i++)
        {
            string[] line = Console.ReadLine().Split();
            int X = int.Parse(line[0]);
            int Y = int.Parse(line[1]);
            graph[X].Add(Y);
            graph[Y].Add(X);
        }

        bool[] visited = new bool[N + 1];
        DFS(graph, 1, visited);

        bool completo = true;
        for (int i = 1; i <= N; i++)
        {
            if (!visited[i])
            {
                completo = false;
                break;
            }
        }

        Console.WriteLine(completo ? "COMPLETO" : "INCOMPLETO");
    }

    static void DFS(List<int>[] graph, int node, bool[] visited)
    {
        visited[node] = true;
        foreach (int neighbor in graph[node])
        {
            if (!visited[neighbor])
            {
                DFS(graph, neighbor, visited);
            }
        }
    }
}
