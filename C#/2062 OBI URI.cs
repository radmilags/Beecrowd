using System;

class MainClass {
  public static void Main (string[] args) 
  {
    int n = int.Parse(Console.ReadLine()); string[] s = new string[n];
    // for(int i = 0; i < n; i++) s[i] = Console.ReadLine();
    s = Console.ReadLine().Split(' ');
    for(int i = 0; i < n; i++)
    {
      if(s[i].Substring(0,2) == "OB" && s[i].Length == 3) s[i] = "OBI";
      if(s[i].Substring(0,2) == "UR" && s[i].Length == 3) s[i] = "URI";
    }
    for(int i = 0; i < n; i++) { if(i == n-1) Console.WriteLine(s[i]); else Console.Write($"{s[i]} "); }
  }
}
