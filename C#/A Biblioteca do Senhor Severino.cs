using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    string s1;
    while(!string.IsNullOrEmpty(s1 = Console.ReadLine()))
    {
      int n = int.Parse(s1);
      int[] s = new int[n];
      for(int i = 0; i < n; i++)
      {
        s[i] = int.Parse(Console.ReadLine());
      }
      Array.Sort(s);
      foreach(int value in s) Console.WriteLine($"{value:0000}"); 
    }
  }
}
