using System;

class MainClass {
  public static void Main (string[] args) 
  {
    string[] s = Console.ReadLine().Split(' ');
    int a = int.Parse(s[0]);
    int b = int.Parse(s[1]);
    long n = b - a + 1;
    long x = ((a+b)*n)/2;
    Console.WriteLine(x);
  }
}
