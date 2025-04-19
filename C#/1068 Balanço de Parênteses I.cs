using System;

class Program {
    static void Main() {
        string linha;
        while (!string.IsNullOrEmpty(linha = Console.ReadLine())) {
            int contador = 0;
            bool correto = true;

            foreach (char c in linha) {
                if (c == '(') {
                    contador++;
                } else if (c == ')') {
                    contador--;
                    if (contador < 0) {
                        correto = false;
                        break;
                    }
                }
            }
            if (contador != 0) correto = false;

            Console.WriteLine(correto ? "correct" : "incorrect");
        }
    }
}
