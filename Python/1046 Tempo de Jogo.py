s = list(map(int, input().split()))
if s[0] < s[1]:
  print("O JOGO DUROU",s[1]-s[0],"HORA(S)")
elif s[0] == s[1]:
  print("O JOGO DUROU 24 HORA(S)")
else:
  zero = 0
  while zero != s[1]:
    zero+=1
  print("O JOGO DUROU",s[1]+24-s[0],"HORA(S)")
