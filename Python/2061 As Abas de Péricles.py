s = list(map(int, input().split()))
# print(s[0])
for i in range(s[1]):
    s1 = input()
    if s1 == "fechou": s[0] +=1 
    else: s[0] -= 1
print(s[0])
