import java.util.Scanner;

public class Main {
  public static void main(String[] args) 
  {
    Scanner scanner = new Scanner(System.in);
    int a = scanner.nextInt();
    int b = scanner.nextInt();
    int c = scanner.nextInt();
    int d = scanner.nextInt();
    int ans = (a*b)-(c*d);
    System.out.println("DIFERENCA = "+ans);
    scanner.close();
  }
}
