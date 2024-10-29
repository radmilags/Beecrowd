using System;

class MainClass {
  public static void Main (string[] args) 
  {
    int x = 1;
    int  n = int.Parse(Console.ReadLine());
    for(int i = n; i >= 1; i--) x *= i;
    Console.WriteLine(x);
  }
}
