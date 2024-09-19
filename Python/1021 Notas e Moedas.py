n = float(input())+0.00001
cem = int(n//100)
n = n%100
cinq = int(n//50)
n = n%50
vint = int(n//20)
n = n%20
dez = int(n//10)
n = n%10
cinc = int(n//5)
n = n%5
dois = int(n//2)
n = n%2
um = int(n//1)
n = n%1
c50 = int(n//0.50)
n = n%0.5
v25 = int(n//0.25)
n = n%0.25
dezc = int(n//0.10)
n = n%0.10
c5 = int(n//0.05)
n = n%0.05
c1 = int(n//0.01)

print("NOTAS:")
print(cem, "nota(s) de R$ 100.00")
print(cinq, "nota(s) de R$ 50.00")
print(vint, "nota(s) de R$ 20.00")
print(dez, "nota(s) de R$ 10.00")
print(cinc, "nota(s) de R$ 5.00")
print(dois, "nota(s) de R$ 2.00")
print("MOEDAS:")
print(um, "moeda(s) de R$ 1.00")
print(c50, "moeda(s) de R$ 0.50")
print(v25 ,"moeda(s) de R$ 0.25")
print(dezc, "moeda(s) de R$ 0.10")
print(c5, "moeda(s) de R$ 0.05")
print(c1, "moeda(s) de R$ 0.01")