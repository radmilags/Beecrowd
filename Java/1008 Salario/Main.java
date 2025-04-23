import java.util.Scanner;
import java.io.IOException;

public class Main{
    public static void main(String[] args){
        Scanner scanner = new Scanner(System.in);
        int n = scanner.nextInt();
        int horas = scanner.nextInt();
        double valor_h = scanner.nextDouble();
        double salario = horas*valor_h;
        String ans = String.format("%.2f", salario);
        System.out.println("NUMBER = "+n);
        System.out.println("SALARY = U$ "+ans);
    }
}