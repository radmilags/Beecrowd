using System;

class MainClass {
  public static void Main (string[] args) 
  {
    Console.Clear();
    string[] s = Console.ReadLine().Split(' '); //total
    string[] s1 = Console.ReadLine().Split(' '); //pedidos
    int a = int.Parse(s[0]);
    int b = int.Parse(s[1]);
    int c = int.Parse(s[2]);
    int d = int.Parse(s1[0]);
    int e = int.Parse(s1[1]);
    int f = int.Parse(s1[2]);

    int x = 0;

    if (a < d) x = d - a;
    if (b < e) x = x + (e - b);
    if (c < f) x = x + (f - c);

    Console.WriteLine(x);
  }
}
/*80 20 40
45 23 48*/ //11
