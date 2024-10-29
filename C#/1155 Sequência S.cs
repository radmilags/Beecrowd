class MainClass {
  public static void Main (string[] args) 
  {
    double s = 0, x;
    for(double i = 1; i <= 100; i++)
    {
      x = 1/i;
      s += x;
    }
    Console.WriteLine($"{s:0.00}");
  }
}
