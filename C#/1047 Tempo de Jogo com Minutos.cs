using System;

class MainClass {
  public static void Main (string[] args) 
  {
    Console.Clear();
    string[] s = Console.ReadLine().Split(' ');
    int a = int.Parse(s[0]);
    int x = int.Parse(s[1]);
    int b = int.Parse(s[2]);
    int y = int.Parse(s[3]);
    int c, d;
    if(a==y && b==y && y==x)
    {
      c = x - y;
      d = 24 + a - b;
      Console.WriteLine($"O JOGO DUROU {d} HORA(S) E {c} MINUTO(S)");
    }
    else if(a==b && y>x)
    {
      c=y-x;
      d=a-b;
      Console.WriteLine($"O JOGO DUROU {d} HORA(S) E {c} MINUTO(S)");
    }
    else if(a==b && x>y)
    {
      c=60-x+y;
      d=24-a+b-1;
      Console.WriteLine($"O JOGO DUROU {d} HORA(S) E {c} MINUTO(S)");
    }
    else if(x==y && a<b)
    {
        c=0;
        d=b-a;
      Console.WriteLine($"O JOGO DUROU {d} HORA(S) E {c} MINUTO(S)");
    }
    else if(x==y && a>b)
    {
        c=0;
        d=24-a+b;
      Console.WriteLine($"O JOGO DUROU {d} HORA(S) E {c} MINUTO(S)");
    }
    else if(b>a && y>x)
    {
        c=y-x;
        d=b-a;
      Console.WriteLine($"O JOGO DUROU {d} HORA(S) E {c} MINUTO(S)");
    }
    else if(a<b && x>y)
    {
        c=60-x+y;
        d=b-a-1;
      Console.WriteLine($"O JOGO DUROU {d} HORA(S) E {c} MINUTO(S)");
    }
    else if(a>b && x<y)
    {
        c=y-x;
        d=24-a-1+b;
      Console.WriteLine($"O JOGO DUROU {d} HORA(S) E {c} MINUTO(S)");
    }
    else if(a>b && x>y)
    {
        c=60+y-x;
        d=24+b-a-1;
      Console.WriteLine($"O JOGO DUROU {d} HORA(S) E {c} MINUTO(S)");
    }
  }
}
