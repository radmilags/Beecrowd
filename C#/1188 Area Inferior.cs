using System; 
class URI {
    static void Main(string[] args) { 

        double [] n = new double [144];
        double m = 0;
        string s = Console.ReadLine();
        for(int i = 0; i < 144; i++)
        {
            n[i] = double.Parse(Console.ReadLine()); 
            m += n[i];
        }
        if(s == "S") Console.WriteLine($"{m:0.0}");
        else Console.WriteLine($"{m/144:0.0}");
    }

}