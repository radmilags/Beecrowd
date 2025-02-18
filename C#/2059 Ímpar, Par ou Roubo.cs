using System;

class MainClass {
  public static void Main (string[] args) 
  {
    Console.Clear();
    string[] s = Console.ReadLine().Split(' ');
    int p = int.Parse(s[0]);
    int j1 = int.Parse(s[1]);
    int j2 = int.Parse(s[2]);
    int r = int.Parse(s[3]);
    int a = int.Parse(s[4]);
    int x = j1 + j2;

    if (r == 0)
    {
      if (x % 2 == p)
      {
        Console.WriteLine("Jogador 2 ganha!");
      }
      else
      {
        Console.WriteLine("Jogador 1 ganha!");
      }
    }
    if (r == 1 && a == 0)
    {      
      Console.WriteLine("Jogador 1 ganha!");
    }
    else if (r == 1 && a == 1)
    {
      Console.WriteLine("Jogador 2 ganha!");
    }
  }
}
/*1 4 5 0 0 Jogador 2*/
/*1 4 5 1 0 Jogador 1*/
