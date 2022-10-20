using System;


class MainClass {
  public static void Main (string[] args) 
  {
    /*double T;
    int N1 = Convert.ToInt32(Console.ReadLine());//número da peça 1
    int Q1 = Convert.ToInt32(Console.ReadLine());//quantidade de peças 1
    double V1 = Convert.ToDouble(Console.ReadLine());
    int N2 = Convert.ToInt32(Console.ReadLine());//número da peça 2
    int Q2 = Convert.ToInt32(Console.ReadLine());//quantidade de peças 2
    double V2 = Convert.ToDouble(Console.ReadLine());
    
    T = (V1*Q1) + (V2*Q2);
    Console.WriteLine ("VALOR A PAGAR: R$ {0:0.00}", T);*/

    string[] p1 = Console.ReadLine().Split(' ');//Split divide a string em partes e coloca num vetor "[]"
    string[] p2 = Console.ReadLine().Split(' ');
    int c1 = int.Parse(p1[0]);
    int n1 = int.Parse(p1[1]);
    double v1 = double.Parse(p1[2]);

    int c2 = int.Parse(p2[0]);
    int n2 = int.Parse(p2[1]);
    double v2 = double.Parse(p2[2]);

    double vp = n1 * v1 + n2 * v2;

    Console.WriteLine($"VALOR A PAGAR: R$ {vp:0.00}");

    /*12 1 5.30
16 2 5.10*/

  }
}
