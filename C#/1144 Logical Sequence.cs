using System;

class MainClass {
  public static void Main (string[] args) 
  {
    int n = int.Parse(Console.ReadLine());
    int a,c,d,e;

    for (int b = 1; b <= n; b++)
    {
      a = b*b;
      c = b*b*b;
      Console.WriteLine($"{b} {a} {c}");
      d = a + 1;
      e = c + 1;
      Console.WriteLine($"{b} {d} {e}");
    }
  }
}
