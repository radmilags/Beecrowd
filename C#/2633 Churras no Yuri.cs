using System;
using System.Collections.Generic;
using System.Linq;

class MainClass {
  public static void Main (string[] args) 
  {
    string z;
    while(!string.IsNullOrEmpty(z = Console.ReadLine())){
        var dados = new List<(string texto, int numero)>();
        string[] s;
        for(int i = 0; i < int.Parse(z); i++){
            s = Console.ReadLine().Split();
            string texto = s[0];
            int numero = int.Parse(s[1]);
            dados.Add((texto, numero));
        }
        var dados_ordenados = dados.OrderBy(d => d.numero);
        Console.WriteLine(string.Join(" ", dados_ordenados.Select(i => i.texto)));
    }
  }
}