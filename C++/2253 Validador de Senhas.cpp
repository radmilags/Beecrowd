#include <iostream>
using namespace std;

int main() {
    string s;
    bool M, m, n, ok;

    while (getline(cin, s)) {
        M = m = n = false;
        ok = s.length() >= 6 && s.length() <= 32;

        if (ok) {
            for (char c : s) {
                if (c >= 'A' && c <= 'Z') M = true;
                else if (c >= 'a' && c <= 'z') m = true;
                else if (c >= '0' && c <= '9') n = true;
                else { 
                    ok = false; 
                    break; 
                }
            }
        }

        if (ok && M && m && n) 
            cout << "Senha valida." << endl;
        else 
            cout << "Senha invalida." << endl;
    }

    return 0;
}
