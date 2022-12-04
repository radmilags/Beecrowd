using System;
class HelloWorld {
  static void Main() 
  {
    int n = int.Parse(Console.ReadLine());
    string[] lista = Console.ReadLine().Split();
    int total = 1;
    for(int x = 2; x < n; x++){
        if (int.Parse(lista[x]) - int.Parse(lista[x-1]) != int.Parse(lista[x-1]) - int.Parse(lista[x-2])) total += 1;
    }
    Console.WriteLine(total);
  }
