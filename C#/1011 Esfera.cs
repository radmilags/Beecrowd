using System;

class MainClass {
  public static void Main (string[] args) 
  {
    double pi = 3.14159;
    double vol;

    double R = double.Parse(Console.ReadLine());
    R = R*R*R;
    vol = (4.0/3) * pi * R;

    Console.WriteLine ("VOLUME = {0:0.000}", vol);

    //ENTRADA: 3
    //SAÍDA: VOLUME = 113.097
  }
}
