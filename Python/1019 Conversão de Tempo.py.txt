n = int(input())
min = 0
h = 0
s = 0
if n < 60: # caso o tempo seja apenas segundos
  s = n
elif n // 60 > 59: #caso o tempo inclua horas
  h = n // 3600
  n = n % 3600
  min = n*60
   
if n // 60 > 0:
  min = n//60
  s = n%60
print(h,":",min,":", s,sep="")