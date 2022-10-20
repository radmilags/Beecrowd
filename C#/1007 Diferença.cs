using System;

class MainClass {
  public static void Main (string[] args) 
  {
  int A = Convert.ToInt32(Console.ReadLine());
  int B = Convert.ToInt32(Console.ReadLine());
  int C = Convert.ToInt32(Console.ReadLine());
  int D = Convert.ToInt32(Console.ReadLine());
  int DIFERENCA; 

  DIFERENCA = (A * B - C * D);
  Console.WriteLine("DIFERENCA = {0}", DIFERENCA);
    
  }
}
