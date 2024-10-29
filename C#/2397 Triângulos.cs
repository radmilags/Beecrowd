using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    string[] s = Console.ReadLine().Split(' ');
    int a = int.Parse(s[0]);
    int b = int.Parse(s[1]);
    int c = int.Parse(s[2]);
    int a2 = a * a; int b2 = b * b; int c2 = c * c;
    if (a >= b + c || b >= a + c || c >= a + b)
    Console.WriteLine("n");
    else if (a2 == b2+c2 || b2 == a2+c2 || c2 == a2+b2)
    Console.WriteLine("r");
    else if (a2>b2+c2 || b2>a2+c2 || c2>a2+b2)
    Console.WriteLine("o");
    else
    Console.WriteLine("a");
  }
}
