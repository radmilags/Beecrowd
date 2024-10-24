using System;

class MainClass {
  public static void Main (string[] args) 
  {
    Console.Clear();
    int x = 0; int j = 0;
    int n = int.Parse(Console.ReadLine());
    int[] a = new int[n];
    string[] s = Console.ReadLine().Split(' ');
    for (int i = 0; i <= n - 1; i++) a[i] = int.Parse(s[i]);
    for (int i = 0; i <= n - 1; i++)
    {
      if (a[i] < x) {x = a[i]; j = i;}
    }
    Console.WriteLine($"Menor valor: {x}");
    Console.WriteLine($"Posicao: {j}");
  }
}
