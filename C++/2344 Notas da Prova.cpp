#include <iostream>

using namespace std;

int main()
{
    int n; cin >> n;
    if (n >= 1 and n <= 35) cout << "D" << endl;
    else if (n >= 36 and n <= 60) cout << "C" << endl;
    else if (n >= 61 and n <= 85) cout << "B" << endl;
    else if (n >= 86 and n <= 100) cout << "A" << endl;
    else cout << "E" << endl;

    return 0;
}
