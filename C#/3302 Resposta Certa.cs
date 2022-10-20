using System;
class HelloWorld {
  static void Main() 
  {
    int n = int.Parse(Console.ReadLine());
    for(int i = 1; i <= n; i++){
        int n1 = int.Parse(Console.ReadLine());
        Console.WriteLine($"resposta {i}: {n1}");
    }
  }
}
