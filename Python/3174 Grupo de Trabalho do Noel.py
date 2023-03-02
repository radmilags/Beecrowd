n = int(input())
a = 0 
b = 0
d = 0
m = 0

# Grupo dos bonecos: 8 horas;
# Grupo dos arquitetos: 4 horas;
# Grupo dos musicos: 6 horas;
# Grupo dos desenhistas: 12 horas.

for i in range(n):
    s = list(input().split())
    if s[1] == "bonecos": b+=int(s[2])
    if s[1] == "arquitetos": a+=int(s[2])
    if s[1] == "musicos": m+=int(s[2])
    if s[1] == "desenhistas": d+=int(s[2])
print((b//8)+(a//4)+(m//6)+(d//12))
    
