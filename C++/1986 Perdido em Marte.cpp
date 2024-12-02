#include <iostream>
#include <string>
using namespace std;
int main()
{
    int n;
    cin >> n;
    string s1;
    for(int i = 1; i <= n; i++){
        string s;
        cin >> s;
        if (s == "61") s1+="a";
        else if (s == "62") s1+="b";
        else if (s == "63") s1+="c";
        else if (s == "64") s1+="d";
        else if (s == "65") s1+="e";
        else if (s == "66") s1+="f";
        else if (s == "67") s1+="g";
        else if (s == "68") s1+="h";
        else if (s == "69") s1+="i";
        else if (s == "6A") s1+="j";
        else if (s == "6B") s1+="k";
        else if (s == "6C") s1+="l";
        else if (s == "6D") s1+="m";
        else if (s == "6E") s1+="n";
        else if (s == "6F") s1+="o";
        else if (s == "70") s1+="p";
        else if (s == "71") s1+="q";
        else if (s == "72") s1+="r";
        else if (s == "73") s1+="s";
        else if (s == "74") s1+="t";
        else if (s == "75") s1+="u";
        else if (s == "76") s1+="v";
        else if (s == "77") s1+="w";
        else if (s == "78") s1+="x";
        else if (s == "79") s1+="y";
        else s1+= "z";
    }
    cout<< s1 << endl;

    return 0;
}
