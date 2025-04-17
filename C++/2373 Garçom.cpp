#include <iostream>
using namespace std;
int main(){
    int copos = 0;
    int n, a, b;
    cin >> n;
    for(int i = 0; i < n; i++){
        cin >> a >> b;
        if(a > b) copos += b;
    }
    cout << copos << endl;
}