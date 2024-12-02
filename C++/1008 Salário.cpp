#include <iostream>
 
using namespace std;
 
int main() {
 int a, b;
  double c, x;
  scanf("%d %d", &a, &b);
  scanf("%lf", &c);
  x = b*c;
  printf("NUMBER = %d\n", a);
  printf("SALARY = U$ %4.2lf\n", x);
  return 0;
}
