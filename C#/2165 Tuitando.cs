using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    string s = Console.ReadLine();
    if(s.Length <= 140) Console.WriteLine("TWEET");
    else Console.WriteLine("MUTE");
  }
}
