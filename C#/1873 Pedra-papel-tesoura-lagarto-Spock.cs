using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    int n = int.Parse(Console.ReadLine());
    for(int i = 1; i <= n; i++)
    {
      string[] s = Console.ReadLine().Split(' ');
      string a = s[0];
      string b = s[1];
      if(a == b) Console.WriteLine("empate");
      else
      {
        if(a == "tesoura")
        {
          if(b == "papel" || b == "lagarto") Console.WriteLine("rajesh");
          else Console.WriteLine("sheldon");
        }
        else if(a == "papel")
        {
          if(b == "pedra" || b == "spock") Console.WriteLine("rajesh");
          else Console.WriteLine("sheldon");
        }
        else if(a == "pedra")
        {
          if(b == "lagarto" || b == "tesoura") Console.WriteLine("rajesh");
          else Console.WriteLine("sheldon");
        }
        else if(a == "lagarto")
        {
          if(b == "papel" || b == "spock") Console.WriteLine("rajesh");
          else Console.WriteLine("sheldon");
        }
        else if(a == "spock")
        {
          if(b == "tesoura" || b == "pedra") Console.WriteLine("rajesh");
          else Console.WriteLine("sheldon");
        }
      }
    }
  }
}
