n = int(input())
x = 0
for i in range(1, n+1):
    s = list(input().split())
    a = int(s[0])
    b = int(s[1])
    for j in range(1,b+1):
        if a%2 != 0: x+=a
        else: 
            a+=1
            x+=a
        a+=2
    print(x)
    x = 0
