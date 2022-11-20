s = list(map(int, input().split()))
s1 = s.copy()
s = sorted(s)
for i in range(0, 3):
  print(s[i])
print("")
for i in range(0, 3):
  print(s1[i])
