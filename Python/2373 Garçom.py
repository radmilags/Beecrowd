n = int(input())
copos = 0
for i in range (n):
    a,b = map(int, input().split())
    if a > b: copos += b
print(copos)