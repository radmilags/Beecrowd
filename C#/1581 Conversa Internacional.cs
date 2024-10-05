using System;

class MainClass {
  public static void Main (string[] args) 
  {
    int n = int.Parse(Console.ReadLine());
    for(int i = 1; i <= n; i++)
    {
      int k = int.Parse(Console.ReadLine());
      string[] s = new string[k]; int z = k-1;
      for(int j = 0; j < k; j++) s[j] = Console.ReadLine();
      string a = s[0];
      for(int j = 1; j < k; j++)
      {
        if(a == s[j]) z--;
      }
      if(z == 0) Console.WriteLine(a);
      else Console.WriteLine("ingles");
    }
  }
}
