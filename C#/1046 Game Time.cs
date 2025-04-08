using System;

class MainClass {
  public static void Main (string[] args) 
  {
    Console.Clear();
    
    string[] s = Console.ReadLine().Split(' ');
    int a = int.Parse(s[0]);
    int b = int.Parse(s[1]);

    if(a == b)
        Console.WriteLine("O JOGO DUROU {0} HORA(S)", 24-a+b);
    else if(a<=b)
        Console.WriteLine("O JOGO DUROU {0} HORA(S)", b-a);
    else
        Console.WriteLine("O JOGO DUROU {0} HORA(S)",24-a+b);
  }
}
