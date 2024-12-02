using System;

class MainClass {
  public static void Main (string[] args) 
  {
    int n = int.Parse(Console.ReadLine());
    int j;
    int x = 0;
    
    for(int i = 1; i <= n; i++)
    {
      string[] s = Console.ReadLine().Split(' ');
      int a = int.Parse(s[0]);
      int b = int.Parse(s[1]);

      if(a == b) Console.WriteLine(x);
      else if(a < b)
      {
        for(j = a + 1; j < b; j++)
            {
              if(j % 2==1 || j % 2 == -1) x += j;
            }
            Console.WriteLine(x);
      }
      else
      {
        for(j = b + 1; j < a; j++)
        {
          if(j % 2 == 1||j % 2 == -1) x += j;
        }
          Console.WriteLine(x);
      }
      x = 0;
    }
  }
}
