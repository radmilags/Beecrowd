using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string line;
        while ((line = Console.ReadLine()) != null)
        {
            string[] firstLine = line.Split();
            int N = int.Parse(firstLine[0]);  
            int M = int.Parse(firstLine[1]);
            int K = int.Parse(firstLine[2]); 

            List<int>[] amigos = new List<int>[N + 1]; 
            for (int i = 1; i <= N; i++)
                amigos[i] = new List<int>();

            for (int i = 0; i < M; i++)
            {
                string[] amizade = Console.ReadLine().Split();
                int a = int.Parse(amizade[0]);
                int b = int.Parse(amizade[1]);
                amigos[a].Add(b);
                amigos[b].Add(a);
            }

           
            bool[] convidado = new bool[N + 1];
            for (int i = 1; i <= N; i++)
                convidado[i] = true;

            Queue<int> fila = new Queue<int>();

            for (int i = 1; i <= N; i++)
            {
                if (amigos[i].Count < K)
                {
                    fila.Enqueue(i);
                    convidado[i] = false;
                }
            }

            while (fila.Count > 0)
            {
                int p = fila.Dequeue();

                foreach (int amigo in amigos[p])
                {
                    if (convidado[amigo])
                    {
                        amigos[amigo].Remove(p);
                        if (amigos[amigo].Count < K)
                        {
                            fila.Enqueue(amigo);
                            convidado[amigo] = false;
                        }
                    }
                }
            }

           
            List<int> resultado = new List<int>();
            for (int i = 1; i <= N; i++)
            {
                if (convidado[i])
                    resultado.Add(i);
            }

            if (resultado.Count == 0)
                Console.WriteLine(0);
            else
                Console.WriteLine(string.Join(" ", resultado));
        }
    }
}
