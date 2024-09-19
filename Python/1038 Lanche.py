s = list(map(int, input().split()))
a = s[0]
x = 0.00
if a == 1:
  x = s[1]*4.0
elif a == 2:
  x = s[1]*4.5
elif a == 3:
  x = s[1]*5.0
elif a == 4:
  x = s[1]*2.0
elif a == 5:
  x = s[1]*1.5
print("Total: R$ {:.2f}".format(x))