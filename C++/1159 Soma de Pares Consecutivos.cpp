#include <iostream>
 
using namespace std;
 
int main() {
 
    int soma = 0;
    int n; cin >> n;
    while (n != 0)
    {
        int x = n;
        if (x % 2 != 0) x++; soma += x;
        for (int i = 1; i <= 4; i++)
        {
            x += 2;
            soma += x;
        }
        cout << soma << endl;
        soma = 0; x = 0; n = 0;
        cin >> n;
    }
 
    return 0;
}
