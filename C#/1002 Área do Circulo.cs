using System;

class MainClass {
  public static void Main (string[] args) {
  
    double raio = double.Parse(Console.ReadLine());
    double area = Math.Pow(raio,2) * 3.14159;
    Console.WriteLine("A={0:0.0000}",area);
  }
}
