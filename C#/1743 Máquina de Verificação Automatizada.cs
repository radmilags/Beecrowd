using System;

class MainClass {
  public static void Main (string[] args) 
  {
    int j = 0;
    string[] s = Console.ReadLine().Split(' ');
    string[] s1 = Console.ReadLine().Split(' ');
    for(int i = 0; i < 5; i++)
    {
      if(s[i] != s1[i]) j++;
    }
    if(j == 5) Console.WriteLine("Y");
    else Console.WriteLine("N");
  }
}
