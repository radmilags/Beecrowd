using System;

class MainClass {
  public static void Main (string[] args) 
  {
    string a = "LIFE IS NOT A PROBLEM TO BE SOLVED";
    int n = int.Parse(Console.ReadLine());
    string b = a.Substring(0,n);
    Console.WriteLine(b);
  }
}
