p1 = int(input())
n1 = int(input())
v1 = float(input())
p2 = int(input())
n2 = int(input())
v2 = float(input())

total = n1*v1+n2*v2;
total = "{:.2f}".format(total)

print("VALOR A PAGAR: R$", total)