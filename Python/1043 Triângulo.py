a, b, c = map(float, input().split())
aux = 0.0
if a < b or a < c:
  if b > c:
    aux = a
    a = b
    b = aux
  else:
    aux = a
    a=c
    c=aux
if a < b+c and b < a+b and c < a+b:
  print("Perimetro =", round(a+b+c, 1))
else:
  print("Area =", round(((a+b) * c)/2, 1))
