using System;

class MainClass {
  public static void Main (string[] args) 
  {
    Console.Clear(); int r, q, e, f = 0;
    string[] s = Console.ReadLine().Split(' ');
    int a = int.Parse(s[0]);
    int b = int.Parse(s[1]);
    if(a<0)
    {
      e=b;
      if(b<0) e=b*-1;
      for(r=0; r<e; r++)
      {
        f=a-r;
        if(f%b==0) break;
      }
      q = f / b;
    }
    else
    {
        q =a / b;
        r=a % b;
    }
    Console.WriteLine($"{q} {r}");
  }
}
