import java.util.Scanner;

class Main {
  public static void main(String[] args) 
  {
    Scanner scanner = new Scanner(System.in);
    double a = scanner.nextDouble();
    double b = scanner.nextDouble();
    double ans = ((a*3.5)+(b*7.5))/11;
    System.out.printf("MEDIA = %.5f\n", ans);
    scanner.close();
  }
}
