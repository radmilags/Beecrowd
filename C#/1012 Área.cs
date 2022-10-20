using System;

class MainClass {
  public static void Main (string[] args) 
  {
    double pi = 3.14159;
    double T,CIR,TRA,Q,R;
    string[] p = Console.ReadLine().Split(' ');
    double A = double.Parse(p[0]);
    double B = double.Parse(p[1]);
    double C = double.Parse(p[2]);

    T = A*C/2;
    CIR = pi*(C*C);
    TRA = (A+B)*C/2;
    Q = B*B;
    R = A*B;

    Console.WriteLine("TRIANGULO: {0:0.000}", T);
    Console.WriteLine("CIRCULO: {0:0.000}", CIR);
    Console.WriteLine("TRAPEZIO: {0:0.000}", TRA);
    Console.WriteLine("QUADRADO: {0:0.000}", Q);
    Console.WriteLine("RETANGULO: {0:0.000}", R);

    /* ENTRADA: 3.0 4.0 5.2
    SAÍDA: TRIANGULO: 7.800
CIRCULO: 84.949
TRAPEZIO: 18.200
QUADRADO: 16.000
RETANGULO: 12.000


12.7 10.4 15.2
TRIANGULO: 96.520
CIRCULO: 725.833
TRAPEZIO: 175.560
QUADRADO: 108.160
RETANGULO: 132.080

*/
  }
}
