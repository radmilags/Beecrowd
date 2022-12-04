using System;
class HelloWorld {
  static void Main() 
  {
    int n = int.Parse(Console.ReadLine());
    string[] s = Console.ReadLine().Split(' ');
    int ans = 0;
    for(int i = 1; i < n; i++){
        if (int.Parse(s[i]) < int.Parse(s[i-1])){
            ans = i+1;
            break;
        }
    }
    Console.WriteLine(ans);
  }
}
