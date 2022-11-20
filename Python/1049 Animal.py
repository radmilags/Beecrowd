a = input()
b = input()
c = input()
if a == "vertebrado":
  if b == "mamifero":
    if c == "onivoro": print("homem")
    else: print("vaca")
  elif b == "ave":
    if c == "carnivoro": print("aguia")
    else: print("pomba")
else:
    if b == "inseto":
      if c == "herbivoro": print("lagarta")
      else: print("pulga")
    else: 
      if c == "onivoro": print("minhoca")
      else: print("sanguessuga")
