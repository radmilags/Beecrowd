s = input()
fechamento = 0
for i in range (len(s)):
    if s[i] == '(': fechamento+=1
    elif fechamento > 0: fechamento-=1
if fechamento <= 0: print("Partiu RU!")
else: print(f"Ainda temos {fechamento} assunto(s) pendente(s)!")