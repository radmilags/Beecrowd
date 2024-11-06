using System;

class MainClass {
  public static void Main (string[] args) 
  {
    int op, x = 0;
    double soma = 0.0, a;
    do
    {
        do
        {
          a = double.Parse(Console.ReadLine());
          if(a >= 0 && a <= 10) {soma += a; x++;}
          else Console.WriteLine("nota invalida");
        }
        while(x != 2);
        Console.WriteLine($"media = {soma/2:0.00}");
      do
      {
        Console.WriteLine("novo calculo (1-sim 2-nao)");
        op = int.Parse(Console.ReadLine());
      }while(op != 1 && op != 2);
      soma = 0; x = 0;
    } while (op == 1);
  }
}
