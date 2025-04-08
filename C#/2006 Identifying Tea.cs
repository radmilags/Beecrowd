using System;

class MainClass {
  public static void Main (string[] args) 
  {
    Console.Clear();
    int n = int.Parse(Console.ReadLine());
    string[] s = Console.ReadLine().Split(' ');
    int a = int.Parse(s[0]);
    int b = int.Parse(s[1]);
    int c = int.Parse(s[2]);
    int d = int.Parse(s[3]);
    int e = int.Parse(s[4]);

    int p = 0;

    if(a == n) p++;
    if(b == n) p++;
    if(c == n) p++;
    if(d == n) p++;
    if(e == n) p++;

    Console.WriteLine(p);
  }
}
