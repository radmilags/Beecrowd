using System;
class HelloWorld {
  static void Main() {
    /*NÃO ESTA CORRETO*/
   	string[] s = Console.ReadLine().Split(); bool verificar;
   	int x1 = int.Parse(s[0]); 
   	int y1 = int.Parse(s[1]); 
   	int x2 = int.Parse(s[2]);
   	int y2 = int.Parse(s[3]);
   	while(x1!=0 && x2!=0 && y1!=0 && y2!=0){
   	    if(x1 == x2 && y1 == y2) Console.WriteLine(0);
   	    else{
   	        verificar = false;
   	        if(x1 == x2 || y1==y2) verificar = true;
    		if(Math.Abs(x1-x2)==Math.Abs(y1-y2)) verificar = true;
    		if(verificar) Console.WriteLine(1);
    		else Console.WriteLine(2);
    		s = Console.ReadLine().Split();
    		x1 = int.Parse(s[0]); 
       	    y1 = int.Parse(s[1]); 
       	    x2 = int.Parse(s[2]);
       	    y2 = int.Parse(s[3]);
   	    }
   	}
  }
}
