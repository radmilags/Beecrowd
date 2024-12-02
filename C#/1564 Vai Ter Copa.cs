using System;

class MainClass {
  public static void Main (string[] args) 
  {
    string s;
    while(!string.IsNullOrEmpty(s = Console.ReadLine()))
    {
      if (s == "0") Console.WriteLine("vai ter copa!");
      else Console.WriteLine("vai ter duas!");
    }
  }
}
