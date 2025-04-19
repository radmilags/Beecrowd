import sys

#tive que trocar o input e o print pois ele são lentos
#o problema estava dando TLE

lines = sys.stdin.read().splitlines()
n = int(lines[0])
for i in range(1, n+1):
    s = lines[i]
    s1 = ""
    for c in s:
        if c.isalpha():
            s1 += chr(ord(c) + 3)
        else:
            s1 += c
    s1 = s1[::-1]
    metade = len(s1) // 2
    ans = ""
    for j in range(len(s1)):
        if j < metade:
            ans += s1[j]
        else:
            ans += chr(ord(s1[j]) - 1)
    print(ans)
