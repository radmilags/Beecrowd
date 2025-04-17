using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    int n = int.Parse(Console.ReadLine());
    int copos = 0;
    for(int i = 0; i < n; i++){
        string[] s = Console.ReadLine().Split();
        if(int.Parse(s[0]) > int.Parse(s[1])) copos += int.Parse(s[1]);
    }
    Console.WriteLine(copos);
  }
}