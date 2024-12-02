#include <iostream>
 
using namespace std;
 
int main() {
 double a, b, c, media;
  scanf("%lf", &a);
  scanf("%lf", &b);
  scanf("%lf", &c);
  media = (a*2) + (b*3) + (c*5);
  media /= 10;
  printf("MEDIA = %1.1lf\n", media);
    return 0;
}
