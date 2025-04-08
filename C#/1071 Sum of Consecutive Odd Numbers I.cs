using System;

class MainClass {
  public static void Main (string[] args) 
  {
    Console.Clear();
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());

    int c = 0;

    if (a == b) Console.WriteLine(c);
    else if (a < b)
    {
      for (a += 1; a < b; a++)
      {
        if (a % 2 != 0) c += a;
      }
      Console.WriteLine(c);
    }
    else if (a > b)
    {
      for (b += 1; b < a; b++)
      {
        if (b % 2 != 0) c += b;
      }
      Console.WriteLine(c);
    }
  }
}
