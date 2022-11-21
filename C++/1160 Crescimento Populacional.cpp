#include <iostream>
using namespace std;
 
int main()
{
    int n, x = 0; cin >> n; long a, b; float pa, pb; 
    for(int i = 1; i <= n; i++){
        cin >> a >> b >> pa >> pb;
        while(a <= b){
            if(x > 100) break;
            a += a*pa/100;
            b += b*pb/100;
            x++; 
        }
        // cout << "a: " << a << endl << "b: " << b << endl << "x: " << x << endl;
        if(x > 100) cout << "Mais de 1 seculo.\n";
        else cout << x << " anos.\n";
        x = 0;
    }
 
    return 0;
}
