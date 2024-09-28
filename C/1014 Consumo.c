#include <stdio.h>

int main(void) 
{
  double x, y;
  scanf("%lf %lf", &x, &y);
  printf("%1.3lf km/l\n", x/y);
  return 0;
}
