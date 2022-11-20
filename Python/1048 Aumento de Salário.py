a = float(input())
x = 0 
y = 0
if a == 400.00:
  y = a/100*15
  x = y+a;
  print("Novo salario: {:.2f}".format(x))
  x -= a
  print("Reajuste ganho: {:.2f}".format(x))
  print("Em percentual: 15 %")
elif a > 400.00 and a < 800.01:
  y = a/100*12;
  x = y+a;
  print("Novo salario: {:.2f}".format(x))
  x -= a;
  print("Reajuste ganho: {:.2f}".format(x))
  print("Em percentual: 12 %")
elif (a > 800.00 and a < 1200.01):
  y = a/100*10;
  x = y+a;
  print("Novo salario: {:.2f}".format(x))
  x -= a;
  print("Reajuste ganho: {:.2f}".format(x))
  print("Em percentual: 10 %");
elif (a > 1200.00 and a < 2000.01):
  y = a/100*7;
  x = y+a;
  print("Novo salario: {:.2f}".format(x))
  x -= a;
  print("Reajuste ganho: {:.2f}".format(x))
  print("Em percentual: 7 %")
elif (a > 2000.00):
  y = a/100*4;
  x = y+a;
  print("Novo salario: {:.2f}".format(x))
  x -= a;
  print("Reajuste ganho: {:.2f}".format(x))
  print("Em percentual: 4 %")
