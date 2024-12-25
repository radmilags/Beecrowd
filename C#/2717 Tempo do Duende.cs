using System;

class MainClass {
  public static void Main (string[] args) 
  {
    Console.Clear();
    int n = int.Parse(Console.ReadLine());
    string[] s = Console.ReadLine().Split(' ');
    int a = int.Parse(s[0]);
    int b = int.Parse(s[1]);
    if(n % (a+b) == 0) Console.WriteLine("Farei hoje!");
    else Console.WriteLine("Deixa para amanha!");
  }
}
