using System;

class MainClass {
  public static void Main (string[] args) 
  {
    string[] s = Console.ReadLine().Split(' ');
    int A = int.Parse(s[0]);
    int B = int.Parse(s[1]);

    if (A > B) {int aux = B; B = A; A = aux;}

    if (B % A == 0)
      Console.WriteLine("Sao Multiplos");
    else
      Console.WriteLine("Nao sao Multiplos");
  }
}
