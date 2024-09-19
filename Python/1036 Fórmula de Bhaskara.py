import math

a, b, c = map(float, input().split())
d = (b * b) - 4 * a * c
r1 = 0
r2 = 0
if a == 0 or d < 0:
  print("Impossivel calcular")
else:
  r = math.sqrt(d)
  r1 = (-b + r) / (2 * a)
  r2 = (-b - r) / (2 * a)
  print("R1 =", round(r1, 5))
  print("R2 =", round(r2, 5))