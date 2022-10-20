a, b, c = input().split(" ")
a = int(a)
b = int(b)
c = int(c)
ab = (a+b+abs(a-b))/2
x = (ab + c + abs(ab-c))/2
print("{:.0f} eh o maior".format(x))