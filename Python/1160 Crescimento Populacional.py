n = int(input())
i = 0
while n:
    a, b, pa, pb = map(float, input().split())
    while a <= b:
        if i > 100: break
        a += a*pa//100
        b += b*pb//100
        i += 1
    if i > 100: print("Mais de 1 seculo.")
    else: print(i, "anos.")
    i = 0
    n-=1
