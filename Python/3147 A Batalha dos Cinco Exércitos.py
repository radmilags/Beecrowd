s = list(map(int, input().split()))
bem = s[0]+s[1]+s[2]+s[5]
mal = s[3]+s[4]
if bem >= mal: print("Middle-earth is safe.")
else: print("Sauron has returned.")
