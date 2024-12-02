using System;

class MainClass {
  public static void Main (string[] args) 
  {
    int n = int.Parse(Console.ReadLine());
    if (n <= 800) Console.WriteLine(1);
    else if (n <= 1400) Console.WriteLine(2);
    else if (n < 1400 || n <= 2000) Console.WriteLine(3);
  }
}
