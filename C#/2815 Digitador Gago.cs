using System;

class MainClass {
  public static void Main (string[] args) 
  {
    string[] s = Console.ReadLine().Split(' ');
    for(int i = 0; i < s.Length; i++)
    {
      if(s[i].Length >= 4)
      {
        if(s[i].Substring(0,2) == s[i].Substring(2,2)) s[i] = s[i].Substring(2);
      }
    }
    for(int i = 0; i < s.Length; i++)
    {
      if(i == s.Length - 1) Console.WriteLine(s[i]);
      else Console.Write($"{s[i]} ");
    }
  }
}
