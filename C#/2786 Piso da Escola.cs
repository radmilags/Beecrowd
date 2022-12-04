using System;
class HelloWorld {
  static void Main() {
    int l = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
    double na = ((l-1) + (c-1))*2;
    double total = (na*0.25 + 0.5);
    double q = (l*c - total) / 0.5;
    Console.WriteLine(q);
    Console.WriteLine(na);
  }
}
