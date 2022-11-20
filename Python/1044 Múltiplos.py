s = list(map(int, input().split()))
b = True
if s[0] < s[1]:
  if s[1]%s[0] == 0:
    print("Sao Multiplos")
  else: 
    print("Nao sao Multiplos")
else:
  if s[0]%s[1] == 0:
    print("Sao Multiplos")
  else: 
    print("Nao sao Multiplos")
