#include <bits/stdc++.h>

using namespace std;

int main()
{
    int n; cin >> n;
    string s;
    for(int i = 0; i < n; i++){
        cin >> s;
        int x = s.length();
        if(x == 3){
            if ((s[0] == 't' && s[1] =='w') || (s[0] == 't' && s[2] =='o') || (s[2] == 'o' && s[1] =='w')) cout << 2 << endl;
            else cout << 1 << endl;
        }
        else cout << 3 << endl;
    }
    return 0;
}
