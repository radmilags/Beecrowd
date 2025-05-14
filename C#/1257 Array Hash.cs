using System;
class MainClass {
  public static int alfabeto(char c){
      int cod = c;
      return cod-65;
  }
  public static void Main() {
    int n = int.Parse(Console.ReadLine());
    int total = 0;
    for(int i = 0; i < n; i++){
        int n1 = int.Parse(Console.ReadLine());
        for(int j = 0; j < n1; j++){
            string s = Console.ReadLine();
            for(int k = 0; k < s.Length; k++){
                total += k + j + alfabeto(Convert.ToChar(s[k]));
            }
        }
        Console.WriteLine(total);
        total = 0;
    }
  }
}
