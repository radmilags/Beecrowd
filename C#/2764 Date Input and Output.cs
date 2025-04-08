using System;

class MainClass {
  public static void Main (string[] args) 
  {
    Console.Clear();
    string[] s = Console.ReadLine().Split('/');
    int d = int.Parse(s[0]);
    int m = int.Parse(s[1]);
    int a = int.Parse(s[2]);

    Console.WriteLine($"{m:00}/{d:00}/{a:00}");
    Console.WriteLine($"{a:00}/{m:00}/{d:00}");
    Console.WriteLine($"{d:00}-{m:00}-{a:00}");
  }
}
