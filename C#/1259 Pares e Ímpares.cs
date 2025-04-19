using System;
using System.Collections.Generic;
class MainClass 
{
  public static void Main (string[] args) 
  {
    int n = int.Parse(Console.ReadLine());
    List<int> pares = new List<int>();
    List<int> impares = new List<int>();
    
    for(int i = 0; i < n; i++){
        int numero = int.Parse(Console.ReadLine());
        if(numero%2==0) pares.Add(numero);
        else impares.Add(numero);
    }
    pares.Sort(); impares.Sort(); impares.Reverse();
    
    foreach(int i in pares) Console.WriteLine(i);
    foreach(int i in impares) Console.WriteLine(i);
  }
}
