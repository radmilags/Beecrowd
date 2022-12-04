using System;
class HelloWorld {
  static void Main() {
    string[] s = Console.ReadLine().Split(' ');
    int a = int.Parse(s[0]); int b = int.Parse(s[1]);
    if (b <= 2) Console.WriteLine("nova");
    else if (b >= 3 && b <= 96 && b > a) Console.WriteLine("crescente");
    else if (b >= 97 && b <= 100) Console.WriteLine("cheia");
    else Console.WriteLine("minguante");
  }
}
