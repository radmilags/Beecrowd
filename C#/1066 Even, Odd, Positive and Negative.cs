using System;

class MainClass {
  public static void Main (string[] args) 
  {
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
    int d = int.Parse(Console.ReadLine());
    int e = int.Parse(Console.ReadLine());
    int x = 0; //números positivos
    int y = 0; //números negativos
    int w = 0; //números pares
    int z = 0; //números ímpares

    if (a > 0) x++;
    else y++;
    if (b > 0) x++;
    else y++;
    if (c > 0) x++;
    else y++;
    if (d > 0) x++;
    else y++;
    if (e > 0) x++;
    else y++;

    if (a == 0) y--;
    if (b == 0) y--;
    if (c == 0) y--;
    if (d == 0) y--;
    if (e == 0) y--;

    if (a%2 == 0) w++;
    else z++;
    if (b%2 == 0) w++;
    else z++;
    if (c%2 == 0) w++;
    else z++;
    if (d%2 == 0) w++;
    else z++;
    if (e%2 == 0) w++;
    else z++;

    Console.WriteLine($"{w} valor(es) par(es)");
    Console.WriteLine($"{z} valor(es) impar(es)");
    Console.WriteLine($"{x} valor(es) positivo(s)");
    Console.WriteLine($"{y} valor(es) negativo(s)");
  }
}
