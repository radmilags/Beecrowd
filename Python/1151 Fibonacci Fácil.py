n = int(input())
a=0
b=1
c = 0
i = 1
while i < n:
    print(a,"", end="")
    c = a+b
    a = b;
    b = c;
    i+=1
print(a)
