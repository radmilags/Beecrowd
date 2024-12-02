using System;

class MainClass {
  public static void Main (string[] args) 
  {
    int a, b;
    do
    {
      string[] s = Console.ReadLine().Split(' ');
      a = int.Parse(s[0]);
      b = int.Parse(s[1]);
      if (a != 0 && b != 0) Console.WriteLine(a+b);
    }while(a != 0 && b != 0);
  }
}
