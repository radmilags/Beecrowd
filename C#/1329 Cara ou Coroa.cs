using System;

class MainClass {
  public static void Main (string[] args) 
  {
      int x = 0, y = 0;
      int n = int.Parse(Console.ReadLine());
      while(n != 0)
      {
          string[] s = Console.ReadLine().Split(' ');
          for(int j = 0; j < n; j++)
          {
            int a = int.Parse(s[j]);
            if (a == 0) x++; else y++;
          }
        Console.WriteLine($"Mary won {x} times and John won {y} times");
        n = int.Parse(Console.ReadLine());
        x = 0; y = 0;
      } 
  }
}
