using System;
class HelloWorld {
  static void Main() {
        int n = int.Parse(Console.ReadLine());
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int n3 = n - (n1+n2);
        if(n1 > n2 && n1 > n3) Console.WriteLine(n1);
        else if(n2 > n1 && n2 > n3) Console.WriteLine(n2);
        else Console.WriteLine(n3);

  }
}
