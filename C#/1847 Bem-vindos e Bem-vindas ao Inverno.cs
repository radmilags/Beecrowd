using System;

class MainClass {
  public static void Main (string[] args) 
  {
   string[] s = Console.ReadLine().Split(' ');
   int a = int.Parse(s[0]);
   int b = int.Parse(s[1]);
   int c = int.Parse(s[2]);
   string x = "";

   if(a > b)
   {
     if(b > c) {if((b-c)<(a-b)) x = ":)"; else x = ":(";}
     else x = ":)";
   }
   else if(b > a)
   {
      if(c>b) {if((c-b) < (b-a)) x = ":("; else x =":)";}
      else x =":(";
   }
    else if(c > b) x =":)";
    else x =":(";
    Console.WriteLine(x);
  }
}
