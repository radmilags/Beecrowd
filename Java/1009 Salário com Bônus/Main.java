import java.util.Scanner;
import java.io.IOException;

public class Main{
    public static void main(String[] args){
        Scanner scanner = new Scanner(System.in);
        String nome = scanner.next();
        double salario = scanner.nextDouble();
        double n_vendas = scanner.nextDouble();
        double bonus = (n_vendas*0.15) + salario;
        String ans = String.format("%.2f", bonus);
        System.out.println("TOTAL = R$ "+ans);
    }
}