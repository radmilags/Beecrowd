using System;
class HelloWorld {
  static void Main() 
  {
    int n = int.Parse(Console.ReadLine());
    if (n >= 1 && n <= 35) Console.WriteLine("D");
    else if (n >= 36 && n <= 60) Console.WriteLine("C");
    else if (n >= 61 && n <= 85) Console.WriteLine("B");
    else if (n >= 86 && n <= 100) Console.WriteLine("A");
    else Console.WriteLine("E");
  }
}
