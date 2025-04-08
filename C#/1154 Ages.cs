using System;

class MainClass {
  public static void Main (string[] args) 
  {
    double a;
    double x = 0;
    double y = 0;

    do
    {
      a = double.Parse(Console.ReadLine());
      if (a > 0) {x += a; y++;}
    } while(a > 0);
    double z = x/y;
    Console.WriteLine($"{z:0.00}");
  }
}
