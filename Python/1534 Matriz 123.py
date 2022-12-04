n = input()
ans = ""
while True:
    try:
        n1 = int(n)
        coluna = n1
        for i in range(1, n1+1):
            for j in range(1, n1+1):
                # print(i, j, linha, coluna)
                if coluna == j: 
                    ans+="2"
                    coluna -= 1
                elif i == j:
                    ans += "1"
                else: ans += "3"
            print(ans)
            ans = ""
        n = input()
    except: break
