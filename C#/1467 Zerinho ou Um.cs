using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    string s;
    while(!string.IsNullOrEmpty(s = Console.ReadLine()))
    {
      string[] n = s.Split(' ');
      int a = int.Parse(n[0]);
      int b = int.Parse(n[1]);
      int c = int.Parse(n[2]);
      if (a != b && b == c) Console.WriteLine("A");
      else if (a == b && a == c) Console.WriteLine("*");
      else if (b != a && a == c) Console.WriteLine("B");
      else if (c != a && a == b) Console.WriteLine("C");
    }
  }
}
