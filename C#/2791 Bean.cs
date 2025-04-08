using System;

class MainClass {
  public static void Main (string[] args) 
  {
    Console.Clear();
    string[] s = Console.ReadLine().Split(' ');
    int a = int.Parse(s[0]);
    int b = int.Parse(s[1]);
    int c = int.Parse(s[2]);
    int d = int.Parse(s[3]);

    int x = 0;

    if (a == 1) x = 1;
    else if (b == 1) x = 2;
    else if (c == 1) x = 3;
    else if (d == 1) x = 4;

    Console.WriteLine(x);
  }
}
