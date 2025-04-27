n = int(input())
for i in range(1, n+1):
    s = list(input().split())
    a = s[0]
    b = s[1]
    if s[0] == s[1]: print(f"Caso #{i}: De novo!")
    else:
        if a == "tesoura":
          if b == "papel" or b == "lagarto": print(f"Caso #{i}: Bazinga!")
          else: print(f"Caso #{i}: Raj trapaceou!")
        elif a == "papel":
            if b == "pedra" or b == "Spock": print(f"Caso #{i}: Bazinga!")
            else: print(f"Caso #{i}: Raj trapaceou!")
        elif a == "pedra":
            if b == "lagarto" or b == "tesoura": print(f"Caso #{i}: Bazinga!")
            else: print(f"Caso #{i}: Raj trapaceou!")
        elif a == "lagarto":
            if b == "papel" or b == "Spock": print(f"Caso #{i}: Bazinga!")
            else: print(f"Caso #{i}: Raj trapaceou!")
        elif a == "Spock":
            if b == "tesoura" or b == "pedra": print(f"Caso #{i}: Bazinga!")
            else: print(f"Caso #{i}: Raj trapaceou!")