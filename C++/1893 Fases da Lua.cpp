#include <iostream>
using namespace std;
int main() {
    int a, b;
    cin >> a >> b;
    if (b <= 2) cout<<"nova\n";
    else if (b >= 3 && b <= 96 && b > a) cout<<"crescente\n";
    else if (b >= 97 && b <= 100) cout<<"cheia\n";
    else cout<<"minguante\n";
    return 0;
}
