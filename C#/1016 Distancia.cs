using System;

class MainClass {
  public static void Main (string[] args) 
  {
    int a = int.Parse(Console.ReadLine());
    int x = (60 * a) / 30;
    Console.WriteLine($"{x} minutos");
  }
}
