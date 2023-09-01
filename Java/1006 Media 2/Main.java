import java.util.Scanner;

class Main {
  public static void main(String[] args) 
  {
    Scanner scanner = new Scanner(System.in);
    double a = scanner.nextDouble();
    double b = scanner.nextDouble();
    double c = scanner.nextDouble();
    double ans = ((a*2)+(b*3)+(c*5))/10;
    System.out.printf("MEDIA = %.1f\n", ans);
    scanner.close();
  }
}
