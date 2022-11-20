a, b, c = map(float, input().split())
m = 0
if a < b:
  m=a
  a=b
  b=m
if a < c:
  m=a
  a=c
  c=m
if b < c:
  m=b
  b=c
  c=m
if a >= b+c: print("NAO FORMA TRIANGULO")
elif a * a == b * b + c * c: print("TRIANGULO RETANGULO")
elif a * a > b * b + c * c: print("TRIANGULO OBTUSANGULO");
elif a * a < b * b + c * c: print("TRIANGULO ACUTANGULO")
if a == b and b == c: print("TRIANGULO EQUILATERO")
elif a == b or b == c: print("TRIANGULO ISOSCELES")
