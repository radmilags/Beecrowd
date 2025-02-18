using System;

class MainClass {
  public static void Main (string[] args) 
  {
    Console.Clear();
    int a, b;

    do
    {
      string[] s = Console.ReadLine().Split(' ');
      a = int.Parse(s[0]);
      b = int.Parse(s[1]);
      if (a > b && a != b) Console.WriteLine("Decrescente");
      else if(a < b && a != b) Console.WriteLine("Crescente");
    } while (a != b);

    Console.ReadKey();
  }
}
/*5 4
7 2
3 8
2 2*/

/*Decrescente
Decrescente
Crescente*/
