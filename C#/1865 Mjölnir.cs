using System;

class MainClass {
  public static void Main (string[] args) 
  {
    int n = int.Parse(Console.ReadLine());
    for(int i = 1; i <= n; i++)
    {
      string[] s = Console.ReadLine().Split(' ');
      string a = s[0];
      if(a == "Thor") Console.WriteLine("Y");
      else Console.WriteLine("N");
    }
  }
}
