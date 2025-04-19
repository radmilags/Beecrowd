using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        int n;
        while ((n = int.Parse(Console.ReadLine())) != 0) {
            Queue<int> cartas = new Queue<int>();
            List<int> descartadas = new List<int>();

            for (int i = 1; i <= n; i++) {
                cartas.Enqueue(i);
            }

            while (cartas.Count > 1) {
                descartadas.Add(cartas.Dequeue());

                cartas.Enqueue(cartas.Dequeue());
            }

            Console.Write("Discarded cards:");
            if (descartadas.Count > 0)
                Console.Write(" " + string.Join(", ", descartadas));
            Console.WriteLine();

            Console.WriteLine("Remaining card: " + cartas.Peek());
        }
    }
}
