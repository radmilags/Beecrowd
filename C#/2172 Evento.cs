using System;

class MainClass {
  public static void Main (string[] args) 
  {
    Console.Clear();
    int a = 0; int b = 0;
    do
    {
      string[] s = Console.ReadLine().Split(' ');
      a = int.Parse(s[0]);
      b = int.Parse(s[1]);

      if (a != 0 && b != 0) Console.WriteLine("{0}", a*b);
    } while(a != 0 && b != 0);
  }
}
/*1 544768710
2 538533133
3 38884958
0 0*/
/*544768710
1077066266
116654874*/
