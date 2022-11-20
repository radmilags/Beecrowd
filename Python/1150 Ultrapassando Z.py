x = int(input())
z = int(input())
while z <= x: z = int(input())
i = x+1
n = 1
while x < z:
  x += i
  i += 1
  n += 1
print(n)
