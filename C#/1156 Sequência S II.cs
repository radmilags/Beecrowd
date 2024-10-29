using System;

class MainClass {
  public static void Main (string[] args) 
  {
    double s = 0, b = 1, x;
    for(double i = 1; i <= 39; i+= 2)
    {
      x = i/b; s += x; b *= 2;
    }
    Console.WriteLine($"{s:0.00}");
  }
}
