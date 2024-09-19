n = int(input())
resto = n
print(n)
c = resto//100
resto = resto%100
c50 = resto//50
resto = resto%50
v = resto//20
resto = resto%20
d = resto//10
resto = resto%10
c5 = resto//5
resto = resto%5
dois = resto//2
resto = resto%2
u = resto//1
print(c, "nota(s) de R$ 100,00")
print(c50, "nota(s) de R$ 50,00")
print(v, "nota(s) de R$ 20,00")
print(d, "nota(s) de R$ 10,00")
print(c5, "nota(s) de R$ 5,00")
print(dois, "nota(s) de R$ 2,00")
print(u, "nota(s) de R$ 1,00")