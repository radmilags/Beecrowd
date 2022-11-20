x = 0
a = float(input())
if a >= 0 and a <= 2000: print("Isento")
elif a >= 2000.01 and a <= 3000:
  a -= 2000;
  x = a*0.08;
  print("R$ {:.2f}".format(x))
elif a >= 3000.01 and a <= 4500:
  a -= 3000;
  x = a*0.18+80;
  print("R$ {:.2f}".format(x))
else:
  a -= 4500
  x = a*0.28+350
  print("R$ {:.2f}".format(x))
