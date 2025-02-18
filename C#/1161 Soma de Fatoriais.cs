using System;

class MainClass 
{
  // 1ª forma de calcular fatorial
  // o que seria long? n faço ideia
  public static long Fat(int n)
  {
    if (n == 0) return 1;
    return n * Fat(n - 1);
  }
  // 2ª forma de calcular fatorial
  public static long Fat2(int n)
  {
    long f = 1;
    for (int i = 1; i <= n; i++) f *= i;
    return f;
  }
  public static void Main (string[] args) 
  {
    //int só vai até 2mi
    string s;
    while(!string.IsNullOrEmpty(s = Console.ReadLine()))
    {
      string[] x = s.Split();
      int a = int.Parse(x[0]);
      int b = int.Parse(x[1]);
      Console.WriteLine(Fat(a) + Fat(b));
    }
  }
}
