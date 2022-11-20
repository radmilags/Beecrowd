s = list(map(float, input().split()))
if s[0] > 0 and s[1] > 0:
  print("Q1")
elif s[0] == 0 and s[1] != 0:
  print("Eixo Y")
elif s[1] == 0 and s[0] != 0:
  print("Eixo X")
elif s[0] == 0 and s[1] == 0:
  print("Origem")
elif s[0] < 0 and s[1] > 0:
  print("Q2")
elif s[0] > 0 and s[1] < 0:
  print("Q4")
elif s[0] < 0 and s[1] < 0:
  print("Q3")