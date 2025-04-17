using System;
using System.Collections.Generic;
using System.Linq;

class MainClass {
  public static void Main (string[] args) 
  {
    string s = Console.ReadLine();
    int fechamento = 0;
    for(int i = 0; i < s.Length; i++){
        if(s[i] == '(') fechamento++;
        else if(fechamento > 0) fechamento--;
    }
    if(fechamento <= 0) Console.WriteLine("Partiu RU!"); 
    else Console.WriteLine($"Ainda temos {fechamento} assunto(s) pendente(s)!");
    
  }
}