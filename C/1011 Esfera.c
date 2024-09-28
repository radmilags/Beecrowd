#include <stdio.h>

int main(void) 
{
  double r;
  scanf("%lf", &r);
  double x = 4.0/3 * 3.14159 * (r*r*r);
  printf("VOLUME = %1.3lf\n", x);
  return 0;
}
