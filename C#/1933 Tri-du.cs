using System;

class MainClass {
  public static void Main (string[] args) 
  {
    Console.Clear();
    string[] s = Console.ReadLine().Split(' ');
    int a = int.Parse(s[0]);
    int b = int.Parse(s[1]);

    if((a <= 13 && a >= 1) && (b >= 1 && b <= 13))
    {
      if (a == b) Console.WriteLine(a);
      else if(a > b) Console.WriteLine(a);
      else Console.WriteLine(b);
    }
  }
}
