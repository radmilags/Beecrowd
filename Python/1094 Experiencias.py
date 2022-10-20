n = int(input())
c = 0
r = 0
s = 0
total = 0
for i in range(n):
    q, a = map(int, input().split())
    if a == "C": c+=q
    if a == "S": s+=q
    if a == "R": r+=q
