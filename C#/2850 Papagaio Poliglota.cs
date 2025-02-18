using System;

class MainClass {
  public static void Main (string[] args) 
  {
    Console.Clear();
    string s;
    while(!string.IsNullOrEmpty(s = Console.ReadLine()))
    {
      switch(s)
      {
        case "esquerda": Console.WriteLine("ingles"); break;
        case "direita": Console.WriteLine("frances"); break;
        case "nenhuma": Console.WriteLine("portugues"); break;
        case "as duas": Console.WriteLine("caiu"); break;
      }
    }
  }
}
