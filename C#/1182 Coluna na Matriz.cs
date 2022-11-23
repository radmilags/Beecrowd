using System;
class HelloWorld {
  static void Main() 
  {
    int n = int.Parse(Console.ReadLine());
    // int[,] s = new int[12,12]; 
    string s = Console.ReadLine();
    string elemento;
    double x = 0;
    for(int i = 0; i < 12; i++){
        for(int j = 0; j< 12; j++){
            elemento = Console.ReadLine();
            if(j == n) x+=double.Parse(elemento);
        }
    }
    if(s == "S") Console.WriteLine($"{x:0.0}");
    else Console.WriteLine($"{x/12:0.0}");
  }
}
