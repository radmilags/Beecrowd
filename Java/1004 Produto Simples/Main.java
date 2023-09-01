import java.util.Scanner;

class Main {
  public static void main(String[] args) 
  {
    Scanner scanner = new Scanner(System.in);
    int a = scanner.nextInt();
    int b = scanner.nextInt();
    int ans = a*b;
    System.out.println("PROD = "+ans);
    scanner.close();
  }
}
