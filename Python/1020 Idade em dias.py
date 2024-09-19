n = int(input()) #dias
ano = 0
mes = 0
dia = 0
ano = n//365
n = n%365
mes = n//30
dia = n%30
print(ano, "ano(s)")
print(mes, "mes(es)")
print(dia, "dia(s)")