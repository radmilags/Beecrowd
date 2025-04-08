using System;

class MainClass {
  public static void Main (string[] args) 
  {
    string[] s = Console.ReadLine().Split(' ');

    double a = double.Parse(s[0]);
    double b = double.Parse(s[1]);
    double c = double.Parse(s[2]);

    double m;
    if(a < b)
    {
      m = a;
      a = b;
      b = m;

    }
     if(a < c)
    {
      m = a;
      a = c;
      c = m;

    }
     if(b < c)
    {
      m = b;
      b = c;
      c = m;

    }

    if (a >= b + c) Console.WriteLine("NAO FORMA TRIANGULO");
    else if (a * a == b * b + c * c) Console.WriteLine("TRIANGULO RETANGULO");
    else if (a * a > b * b + c * c) Console.WriteLine("TRIANGULO OBTUSANGULO");
    else if (a * a < b * b + c * c) Console.WriteLine("TRIANGULO ACUTANGULO");
    if (a == b && b == c) Console.WriteLine("TRIANGULO EQUILATERO");
    else if (a == b || b == c) Console.WriteLine("TRIANGULO ISOSCELES");
  }
}
