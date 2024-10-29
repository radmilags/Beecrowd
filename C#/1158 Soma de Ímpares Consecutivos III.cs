using System;

class MainClass {
  public static void Main (string[] args) 
  {
    Console.Clear();
    int x = 0;
    int n = int.Parse(Console.ReadLine());
    for(int i = 1; i <= n; i++)
    {
      string[] s = Console.ReadLine().Split(' ');
      int a = int.Parse(s[0]);
      int b = int.Parse(s[1]);
      for(int j = 1; j <= b; j++)
      {
        if(a % 2 != 0) x += a;
        else { a++; x += a;}
        a += 2;
      }
      Console.WriteLine(x);
      x = 0;
    }
  }
}
