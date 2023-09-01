import java.util.Scanner;
import java.text.DecimalFormat;

class Main {
  public static void main(String[] args) 
  {
    Scanner scanner = new Scanner(System.in);
    DecimalFormat formato = new DecimalFormat("#.####");
    double a = scanner.nextDouble();
    double ans = 3.14159*a*a;
    System.out.printf("A=%.4f\n",ans);
    //String ans1 = formato.format(ans);
    //System.out.println("A="+ans1);
    scanner.close();
  }
}
