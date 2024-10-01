#include <stdio.h>

int main(void) 
{
  double x1, y1, x2, y2, x, y;
  scanf("%lf %lf", &x1, &y1);
  scanf("%lf %lf", &x2, &y2);
  x = (x1 - x2) * (x1 - x2); y = (y1 - y2) * (y1 - y2);
  double d = x + y;
  d = sqrt(d);
  printf("%.4lf\n", d);
  return 0;
}
