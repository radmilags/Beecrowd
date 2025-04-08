using System;

class MainClass {
  public static void Main (string[] args) 
  {
    Console.Clear();

    string[] s = Console.ReadLine().Split(' ');
    int inter = int.Parse(s[0]);
    int gremio = int.Parse(s[1]);

    int it = 0; 
    int gr = 0; 
    int g = 0; 
    int i = 0;
    int e = 0;

    if (inter > gremio) it++;
    else gr++;
    if (inter == gremio) e++;

    do
    {
    Console.WriteLine("Novo grenal (1-sim 2-nao)");
    g = int.Parse(Console.ReadLine());
    if (g == 1) 
    {
      s = Console.ReadLine().Split(' ');
      inter = int.Parse(s[0]);
      gremio = int.Parse(s[1]);
      if (inter > gremio) it++;
      else gr++;
      if (inter == gremio) e++;
    }
    i++;
    } while(g != 2);

    Console.WriteLine($"{i} grenais");
    Console.WriteLine($"Inter:{it}");
    Console.WriteLine($"Gremio:{gr}");
    Console.WriteLine($"Empates:{e}");
    if (it > e) Console.WriteLine($"Inter venceu mais");
    else Console.WriteLine($"Gremio venceu mais");

  }
}
