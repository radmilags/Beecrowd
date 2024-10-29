using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    int a = int.Parse(Console.ReadLine());
    while(a != 0)
    {
      string[] s = Console.ReadLine().Split(' ');
      int m = int.Parse(s[0]);
      int n = int.Parse(s[1]);
      if(m < n) Console.WriteLine(1);
      else if(m % n == 0) Console.WriteLine(m/n);
      else Console.WriteLine((m/n) + 1);
      a--;
    }
  }
}
