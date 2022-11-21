s = 0.0
b = 1
i = 1
while i <= 39:
    x=i/b
    s+=x
    b*=2
    i+=2
print("{:.2f}".format(s))
