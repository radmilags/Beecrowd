using System;

class URI {
    static void Main(string[] args) { 
        double[,] n = new double[12, 12];
        double m = 0;
        string s = Console.ReadLine();
        
        for(int i = 0; i < 12; i++) {
            for (int j = 0; j < 12; j++) {
                n[i, j] = double.Parse(Console.ReadLine());
            }
        }

        for (int i = 7; i <= 11; i++) {
            for (int j = 12 - i; j <= i-1; j++) {
                m += n[i, j];
            }
        }

        if(s == "S") 
            Console.WriteLine($"{m:0.0}");
        else 
            Console.WriteLine($"{m / 30:0.0}");
    }
}