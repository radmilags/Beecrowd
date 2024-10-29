using System;

class MainClass {
  public static void Main (string[] args) 
  {
    string[] s = Console.ReadLine().Split(' ');
    int r = int.Parse(s[0]);
    int l = int.Parse(s[1]);
    double v = 3.1415*r*r*r*4/3;
    v = l/v;
    v = (int) v;
    Console.WriteLine(v);
  }
}
