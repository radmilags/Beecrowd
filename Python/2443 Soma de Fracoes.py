def mmc(a, b):
    m = 1
    i = 2
    while a!=1 or b!=1:
        if a%i==0 or b%i==0: m*=i
        if a%i==0: a = a//i
        if b%i==0: b = b//i
        i+=1
    return m

n, d, n1, d1 = map(int, input().split())
mmc = mmc(d, d1)
numerador = ((mmc//d*n) + (mmc//d1*n1)) #calcula o numerador e já soma os dois
if mmc%numerador == 0: 
    mmc = mmc//numerador
    numerador = numerador // numerador
if numerador%mmc==0:
    numerador = numerador // mmc
    mmc = mmc // mmc
print(numerador, mmc)