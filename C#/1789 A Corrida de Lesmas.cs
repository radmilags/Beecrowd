using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    string z;
    while(!string.IsNullOrEmpty(z = Console.ReadLine()))
    {
      int n = int.Parse(z);
      string[] s = Console.ReadLine().Split(' ');
      int[] a = Array.ConvertAll(s, int.Parse);
      Array.Sort(a);
      if(a[n-1] < 10) Console.WriteLine(1);
      else if(a[n-1] >= 10 && a[n-1] < 20) Console.WriteLine(2);
      if(a[n-1] >= 20) Console.WriteLine(3);
    }
  }
}
