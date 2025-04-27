using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            string[] s = Console.ReadLine().Split();

            if (s[0] == s[1])
            {
                Console.WriteLine($"Caso #{i}: De novo!");
            }
            else
            {
                if (s[0] == "tesoura")
                {
                    if (s[1] == "papel" || s[1] == "lagarto")
                        Console.WriteLine($"Caso #{i}: Bazinga!");
                    else
                        Console.WriteLine($"Caso #{i}: Raj trapaceou!");
                }
                else if (s[0] == "papel")
                {
                    if (s[1] == "pedra" || s[1] == "Spock")
                        Console.WriteLine($"Caso #{i}: Bazinga!");
                    else
                        Console.WriteLine($"Caso #{i}: Raj trapaceou!");
                }
                else if (s[0] == "pedra")
                {
                    if (s[1] == "lagarto" || s[1] == "tesoura")
                        Console.WriteLine($"Caso #{i}: Bazinga!");
                    else
                        Console.WriteLine($"Caso #{i}: Raj trapaceou!");
                }
                else if (s[0] == "lagarto")
                {
                    if (s[1] == "papel" || s[1] == "Spock")
                        Console.WriteLine($"Caso #{i}: Bazinga!");
                    else
                        Console.WriteLine($"Caso #{i}: Raj trapaceou!");
                }
                else if (s[0] == "Spock")
                {
                    if (s[1] == "tesoura" || s[1] == "pedra")
                        Console.WriteLine($"Caso #{i}: Bazinga!");
                    else
                        Console.WriteLine($"Caso #{i}: Raj trapaceou!");
                }
            }
        }
    }
}
