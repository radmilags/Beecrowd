n = input().split()
s = list(map(int,input().split()))
s1 = list(map(int,input().split()))
x = 0
for i in s:
    if not i in s1:
        x+=1
print(x)
