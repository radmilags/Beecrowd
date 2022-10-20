using System;
class HelloWorld {
  static void Main() 
  {
    int n = int.Parse(Console.ReadLine());
    string s;
    for(int i = 0; i < n; i++){
        s = Console.ReadLine();
        int x = s.Length;
        if(x == 3){
            if ((s[0] == 't' && s[1] =='w') || (s[0] == 't' && s[2] =='o') || (s[2] == 'o' && s[1] =='w')) Console.WriteLine(2);
            else Console.WriteLine(1);
        }
        else Console.WriteLine(3);
    }
  }
}
