using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    int n = int.Parse(Console.ReadLine()); double soma = 0;
    while(n != 0)
    {
      int a = int.Parse(Console.ReadLine());
      for(int i = 0; i < a; i++)
      {
        soma += Math.Pow(2, i);
      }
      Console.WriteLine(soma);
      soma = 0; n--;
    }
  }
}
