n = int(input())
media = 0
i = 0
while n > 0:
    media += n
    i += 1
    n = int(input())
if media > 0: print("{:.2f}".format(media/i))
