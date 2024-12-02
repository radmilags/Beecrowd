using System;

class MainClass {
  public static void Main (string[] args) 
  {
    Console.Clear();
    string[] s = Console.ReadLine().Split(' ');
    int cv = int.Parse(s[0]);
    int ce = int.Parse(s[1]);
    int cs = int.Parse(s[2]);
    int fv = int.Parse(s[3]);
    int fe = int.Parse(s[4]);
    int fs = int.Parse(s[5]);
    string n = "";
    int v1 = cv*3 + ce; int v2 = fv * 3 + fe;

    if (v1 != v2)
    {
      if(v1 > v2) n ="C";
      else if (v2 > v1) n = "F";
    }
    else
    {
      if (cs > fs) n = "C";
      else if (fs > cs) n = "F";
      else n = "=";
    }
    Console.WriteLine(n);
  }
}
