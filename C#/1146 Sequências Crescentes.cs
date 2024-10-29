using System;

class MainClass {
  public static void Main (string[] args) 
  {
    int n;
    do
    {
      n = int.Parse(Console.ReadLine());
      if(n != 0)
      {
        for(int i = 1; i <= n; i++)
        {
          if(i == n) Console.WriteLine(i);
          else Console.Write($"{i} ");
        }
      }
    }while (n != 0);
  }
}
