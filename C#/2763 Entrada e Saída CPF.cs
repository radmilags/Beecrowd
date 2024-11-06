using System;

class MainClass {
  public static void Main (string[] args) 
  {
    string[] s = Console.ReadLine().Split('.');
    string a = s[0];
    string b = s[1];
    string c = s[2];
    string[] x = c.Split('-');
    string d = x[0];
    string e = x[1];
    Console.WriteLine(a);
    Console.WriteLine(b);
    Console.WriteLine(d);
    Console.WriteLine(e);

  }
}
