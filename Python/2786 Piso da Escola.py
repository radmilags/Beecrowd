l = int(input())
c = int(input())
na = ((l-1) + (c-1))*2
total = (na*0.25 + 0.5)
q = (l*c - total) / 0.5
print("{:.0f}".format(q))
print(na)
