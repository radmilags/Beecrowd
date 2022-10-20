n1, n2, n3, n4 = input().split(" ")
nf = 0
mf = 0
n1 = float(n1)
n2 = float(n2)
n3 = float(n3)
n4 = float(n4)
m1 = ((n1*2) + (n2*3) + (n3*4) + n4)/10
if m1 < 5.9:
    print("Aluno reprovado.")
elif m1 >= 5.0 and m1 <= 6.9:
    print("Aluno em exame.")
    nf = float(input())
    mf = (nf+m1)/2
    # if mf fazer + tarde
else:
    print("Aluno aprovado.")