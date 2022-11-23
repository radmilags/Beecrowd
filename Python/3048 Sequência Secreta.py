n = int(input())
s = []
x = 1
for i in range(n):
    n1 = int(input())
    s.append(n1)
    if s[i] != s[i-1]: x+=1
print(x)
