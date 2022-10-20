using System;
class HelloWorld {
  static void Main() 
  {
    int n = int.Parse(Console.ReadLine());
    while(n!=0){
        int maior = n;
        while(n!=1){
            
            if(n%2 == 0) n = n/2;
            else n  = n*3+1;
            if(n > maior) maior = n;   
        }
        Console.WriteLine(maior);
        n = int.Parse(Console.ReadLine());
    }
  }
}
