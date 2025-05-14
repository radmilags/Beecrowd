using System;
using System.Collections.Generic;

class Labirinto
{
    static int[,] dist;
    static List<int>[] graph;

    static void FloydWarshall(int V)
    {
        for (int k = 0; k < V; k++)
            for (int i = 0; i < V; i++)
                for (int j = 0; j < V; j++)
                    if (dist[i, k] + dist[k, j] < dist[i, j])
                        dist[i, j] = dist[i, k] + dist[k, j];
    }

    static int BitDP(int mask, int[] oddVertices, int[,] cost, Dictionary<int, int> memo)
    {
        if (mask == 0) return 0;
        if (memo.ContainsKey(mask)) return memo[mask];

        int min = int.MaxValue;
        for (int i = 0; i < oddVertices.Length; i++)
        {
            if ((mask & (1 << i)) != 0)
            {
                for (int j = i + 1; j < oddVertices.Length; j++)
                {
                    if ((mask & (1 << j)) != 0)
                    {
                        int newMask = mask ^ (1 << i) ^ (1 << j);
                        min = Math.Min(min, cost[i, j] + BitDP(newMask, oddVertices, cost, memo));
                    }
                }
                break;
            }
        }
        return memo[mask] = min;
    }

    static void Main()
    {
        int T = int.Parse(Console.ReadLine());
        for (int t = 0; t < T; t++)
        {
            int start = int.Parse(Console.ReadLine());
            string[] va = Console.ReadLine().Split();
            int V = int.Parse(va[0]);
            int A = int.Parse(va[1]);

            graph = new List<int>[V];
            for (int i = 0; i < V; i++)
                graph[i] = new List<int>();

            int[,] edgeCount = new int[V, V];
            dist = new int[V, V];
            for (int i = 0; i < V; i++)
                for (int j = 0; j < V; j++)
                    dist[i, j] = (i == j) ? 0 : int.MaxValue / 2;

            for (int i = 0; i < A; i++)
            {
                string[] parts = Console.ReadLine().Split();
                int u = int.Parse(parts[0]);
                int v = int.Parse(parts[1]);

                graph[u].Add(v);
                graph[v].Add(u);
                edgeCount[u, v]++;
                edgeCount[v, u]++;
                dist[u, v] = dist[v, u] = 1;
            }

            FloydWarshall(V);

            int edgeMovements = A;

            List<int> oddDegreeVertices = new List<int>();
            for (int i = 0; i < V; i++)
                if (graph[i].Count % 2 == 1)
                    oddDegreeVertices.Add(i);

            if (oddDegreeVertices.Count == 0)
            {
                Console.WriteLine(edgeMovements);
            }
            else
            {
                int n = oddDegreeVertices.Count;
                int[,] cost = new int[n, n];

                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        cost[i, j] = dist[oddDegreeVertices[i], oddDegreeVertices[j]];

                Dictionary<int, int> memo = new Dictionary<int, int>();
                int minExtra = BitDP((1 << n) - 1, oddDegreeVertices.ToArray(), cost, memo);
                Console.WriteLine(edgeMovements + minExtra);
            }
        }
    }
}