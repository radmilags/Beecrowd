using System;

class MainClass {
  public static void Rafael(int x, int y, out int a)
  {
    x = 3*x;
    a = x*x + y*y;
  }
  public static void Beto(int x, int y, out int a)
  {
    x = x * x; y = y*5;
    a = x*2 + y*y;
  }
  public static void Carlos(int x, int y, out int a)
  {
    x *= -100; y = y*y*y;
    a = x + y;
  }
  public static void Main (string[] args) 
  {
    int n = int.Parse(Console.ReadLine());
    int r, b, c;
    for(int i = 1; i <= n; i++)
    {
      string[] s = Console.ReadLine().Split(' ');
      int x = int.Parse(s[0]);
      int y = int.Parse(s[1]);

      Rafael(x, y, out r);
      Beto(x, y, out b);
      Carlos(x, y, out c);

      if (r > b && r > c) Console.WriteLine("Rafael ganhou");
      else if (b > r && b > c) Console.WriteLine("Beto ganhou");
      else Console.WriteLine("Carlos ganhou");
    }
  }
}
