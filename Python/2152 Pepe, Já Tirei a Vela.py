n = int(input())
for _ in range(n):
    h, m, o = map(int, input().split())
   
    time = f"{h:02}:{m:02}"
    if o == 1:
        action = "A porta abriu!"
    else:
        action = "A porta fechou!"
    print(f"{time} - {action}")
