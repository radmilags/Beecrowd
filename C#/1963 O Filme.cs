using System;

class MainClass {
  public static void Main (string[] args) 
  {
    string[] s = Console.ReadLine().Split(' ');
    double a = double.Parse(s[0]);
    double b = double.Parse(s[1]);
    double x = b - a; double y = 0;
    if (x > 0) {y = x*100/a; Console.WriteLine($"{y:0.00}%");}
    else Console.WriteLine($"0.00%");
  }
}
