#include <iostream>
#include <cmath>

using namespace std;
int main() {
    int x1, y1, x2, y2;
    cin >> x1 >> y1 >> x2 >> y2;
    while(x1 !=0 and x2 != 0 and y1 !=0 and y2!=0){
	
    	if(x1 == x2 and y1 == y2) cout << 0 << endl;
    	else{
    		bool verificar = false;
    		if(x1 == x2 or y1==y2) verificar = true;
    		if(abs(x1-x2)==abs(y1-y2)) verificar = true;
    		if(verificar) cout << 1 << endl;
    		else cout << 2 << endl;
		}
    	
		cin >> x1 >> y1 >> x2 >> y2;
   	}
    return 0;
}
