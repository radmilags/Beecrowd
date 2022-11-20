s = list(map(int, input().split()))

if s[1] > s[2] and s[3] > s[0] and s[2]+s[3] > s[0]+s[1] and s[2] >= 0 and s[3] >= 0 and s[0]%2 == 0: print("Valores aceitos")