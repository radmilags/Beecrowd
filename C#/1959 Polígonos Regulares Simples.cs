using System;
class HelloWorld {
  static void Main() {
    string[] s = Console.ReadLine().Split(' ');
    Console.WriteLine(long.Parse(s[0])*long.Parse(s[1]));
  }
}
