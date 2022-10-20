using System;

class MainClass {
  public static void Main (string[] args) 
  {
   int N = Convert.ToInt32(Console.ReadLine());   
   int V = Convert.ToInt32(Console.ReadLine());
   double H = Convert.ToDouble(Console.ReadLine());
   double SALARY;
   
   SALARY = H*V;
   Console.WriteLine("NUMBER = {0}",N);
   Console.WriteLine("SALARY = U$ {0:0.00}",SALARY);
  }
}
