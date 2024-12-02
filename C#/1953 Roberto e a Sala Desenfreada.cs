using System;

class MainClass {
  public static void Main (string[] args) 
  {
    string s;
    int intruso = 0; int epr = 0; int ehd = 0;
    while(!string.IsNullOrEmpty(s = Console.ReadLine()))
    {
      int n = int.Parse(s);
      for(int i = 1; i <= n; i++)
      {
        string[] v = Console.ReadLine().Split(' ');
        string b = v[1];
        if (b == "EPR") epr++;
        else if (b == "EHD") ehd++;
        else if (b != "EPR" && b != "EHD") intruso++;
      }
      Console.WriteLine($"EPR: {epr}");
      Console.WriteLine($"EHD: {ehd}");
      Console.WriteLine($"INTRUSOS: {intruso}");
      epr = ehd = intruso = 0;
    }
  }
}
