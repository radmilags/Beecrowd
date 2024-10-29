using System;
// W = 1; H = 1/2; Q = 1/4; E = 1/8; S = 1/16; T = 1/32; X = 1/64;
class MainClass 
{
  public static void Main (string[] args) 
  {
    double cont = 0; int z = 0;
    string ler = Console.ReadLine();
    do
    {
      string[] s = ler.Split('/');
      for(int i = 0; i < s.Length; i++)
      {
        string a = s[i];
        for(int j = 0; j < a.Length; j++)
        {
          string x = a.Substring(j, 1);
          if(x == "W") cont += 1;
          if(x == "H") cont += 0.5;
          if(x == "Q") cont += 0.25;
          if(x == "E") cont += 0.125;
          if(x == "S") cont += 0.0625;
          if(x == "T") cont += 0.03125;
          if(x == "X") cont += 0.015625;
        }
        if(cont == 1) z++;
        cont = 0;
      }
      Console.WriteLine(z);
      ler = Console.ReadLine();
      z = 0;
    }while(ler != "*");
  }
}
