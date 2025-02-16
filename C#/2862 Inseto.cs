using System;

class MainClass {
  public static void Main (string[] args) 
  {
    int n = int.Parse(Console.ReadLine());
    for(int i = 1; i <= n; i++)
    {
      int a = int.Parse(Console.ReadLine());
      if(a > 8000) Console.WriteLine("Mais de 8000!");
      else Console.WriteLine("Inseto!");
    }
  }
}
