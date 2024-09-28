#include <stdio.h>

int main(void) 
{
  double a, b, y;
  scanf("%lf %lf", &a, &b);
  double x = b - a;
  if (x > 0) 
  {
    y = x*100/a; printf("%1.2lf%%\n", y);
  }
  else printf("0.00%%\n");
  return 0;
}