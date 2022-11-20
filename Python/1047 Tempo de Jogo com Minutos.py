a,x,b,y = map(int, input().split())
if a==y and b==y and y==x:
  c=x-y
  d=24+a-b
elif a==b and y>x:
  c=y-x
  d=a-b
elif a==b and x>y:
  c=60-x+y
  d=24-a+b-1
elif x==y and a<b:
  c=0
  d=b-a
elif x==y and a>b:
  c=0
  d=24-a+b
elif b>a and y>x: 
  c=y-x
  d=b-a
elif a<b and x>y:
  c=60-x+y
  d=b-a-1
elif a>b and x<y:
  c=y-x
  d=24-a-1+b
elif a>b and x>y:
  c=60+y-x
  d=24+b-a-1
print("O JOGO DUROU",d, "HORA(S) E",c,"MINUTO(S)")
