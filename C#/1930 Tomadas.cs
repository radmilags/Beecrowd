using System;

class MainClass {
  public static void Main (string[] args) 
  {
    string[] s = Console.ReadLine().Split(' ');
    int T1 = int.Parse(s[0]);
    int T2 = int.Parse(s[1]);
    int T3 = int.Parse(s[2]);
    int T4 = int.Parse(s[3]);

    T1 = T1-1;
    T2 = T2-1;
    T3 = T3-1;
    int a = T1 + T2 + T3 + T4;
    Console.WriteLine($"{a}");
  }
}
