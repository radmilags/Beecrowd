#include <bits/stdc++.h>

using namespace std;

int main()
{
    int n; cin >> n; int x = 0; bool bo = true; string a, b;
    for(int i = 1; i <= n; i++){
        cin >> a >> b;
        if (a.length() < b.length()) cout << "nao encaixa\n";
        else{
            for(int j = a.length()-b.length(); j < a.length(); j++){
                if (a[j] != b[x]){
                    bo = false;
                    //cout << x << j << a[j] << b[x];
                    break;
                }
                x+=1;
            }
            //cout << x << j << a[j] << b[x];
            if (bo) cout << "encaixa\n";
            else cout << "nao encaixa\n";
            bo = true;
            x = 0;
            
        }
    }
    return 0;
}
