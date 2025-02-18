using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    Console.Clear(); 
    string[] s = Console.ReadLine().Split(' ');
    double a = double.Parse(s[0]);
    double b = double.Parse(s[1]);
    double c = double.Parse(s[2]);

    double aux;
    if (a < b || a < c)
    if (b > c)
    {
      aux = a;
      a = b;
      b = aux;
    }
    else
    {
      aux = a;
      a = c;
      c = aux;
    }

    if (a < b+c && b < a+b && c < a+b)
    {
      double p = a + b + c;
      Console.WriteLine($"Perimetro = {p:0.0}");
    }
    else
    {
      double t = Math.Round((((a + b) * c)) / 2);
      Console.WriteLine($"Area = {t:0.0}");
    }
    
  }
}
/* | b - c | < a < b + c 
| a - c | < b < a + c 
| a - b | < c < a + b */
/*6.0 4.0 2.0  Area = 10.0*/
// 6.0 4.0 2.1 // Perimetro = 12.1
