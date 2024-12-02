using System;

class MainClass {
  public static void Main (string[] args) 
  {
    string[] s = Console.ReadLine().Split(' ');
    int a = int.Parse(s[0]);
    int b = int.Parse(s[1]);
    int c = int.Parse(s[2]);
    int max = a; int men = a;
    if (b > max) max = b;
    if (c > max) max = c;
    if (b < men) men = b;
    if (c < men) men = c;
    if ((max == a && men == c) || (max == c && men == a)) Console.WriteLine(b);
    else if ((max == a && men == b) || (max == b && men == a)) Console.WriteLine(c);
    if ((max == b && men == c) || (max == c && men == b)) Console.WriteLine(a);
  }
}
