#include <iostream>

using namespace std;

int main()
{
    int n; cin >> n;
    if(n > 50 && n <= 100) cout << "Top 100" << endl;
    else if(n > 25 && n <= 50) cout << "Top 50" << endl;
    else if(n > 10 && n <= 25) cout << "Top 25" << endl;
    else if(n > 5 && n <= 10) cout << "Top 10" << endl;
    else if(n > 3 && n <= 5) cout << "Top 5" << endl;
    else if(n > 1 && n <= 3) cout << "Top 3" << endl;
    else cout << "Top 1" << endl;

    return 0;
}
/*1, 3, 5, 10, 25, 50 e 100.*/
