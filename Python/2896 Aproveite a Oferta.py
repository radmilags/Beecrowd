n = int(input())
x = 0
for i in range(n):
    a, b = map(int, input().split())
    if a < b: print(a)
    else: print(a//b+a%b)
