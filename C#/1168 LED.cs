using System;

class MainClass {
  public static void Main (string[] args) 
  {
    int n = int.Parse(Console.ReadLine());
    int x = 0; int cont = 0;
    string y = " ";
    for(int i = 1; i <= n; i++)
    {
      string s = Console.ReadLine();
      x = s.Length;
      for(int j = 0; j <= x - 1; j++)
      {
        y = s.Substring(j,1);
        switch (y)
        {
          case "1": cont += 2; break;
          case "2": cont += 5; break;
          case "3": cont += 5; break;
          case "4": cont += 4; break;
          case "5": cont += 5; break;
          case "6": cont += 6; break;
          case "7": cont += 3; break;
          case "8": cont += 7; break;
          case "9": cont += 6; break;
          case "0": cont += 6; break;
        }
      }
      Console.WriteLine($"{cont} leds");
      x = 0; cont = 0;
    }
  }
}
/*3
115380
2819311
23456

27 leds
29 leds
25 leds*/
