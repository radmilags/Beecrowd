using System;

class Program {
  public static void Main (string[] args) {
  string s;
  while(!string.IsNullOrEmpty(s = Console.ReadLine()))
    {
      string[] s1 = s.Split(' ');
      long a = long.Parse(s1[0]);
      long b = long.Parse(s1[1]);
      if (a > b) Console.WriteLine(a-b);
      else Console.WriteLine(b-a);
    }
  }
}
