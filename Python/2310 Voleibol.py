saque = 0.0
bloqueio = 0.0
ataque = 0.0
ts = 0.0 
tb = 0.0 
ta = 0.0 
for i in range(int(input())):
    nome = input()
    s = list(map(float, input().split()))
    s1 = list(map(float, input().split()))
    ts += s[0]
    tb += s[1]
    ta += s[2]
    saque += s1[0]
    bloqueio += s1[1]
    ataque += s1[2]
    
saque = saque*100/ts
bloqueio *= 100/tb
ataque *= 100/ta

print("Pontos de Saque: {:.2f} %.".format(saque))
print("Pontos de Bloqueio: {:.2f} %.".format(bloqueio))
print("Pontos de Ataque: {:.2f} %.".format(ataque))
