using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
    int x = 0, w = 0, z = 0;
    w = (b*2)+(c*4);
    x = (c*2)+(a*2);
    z = (b*2)+(a*4);
    if(w <= x && w <= z) Console.WriteLine(w);
    else if(x <= w && x <= z) Console.WriteLine(x);
    else if(z <= x && z <= w) Console.WriteLine(z);
  }
}
