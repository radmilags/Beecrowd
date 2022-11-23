#include <stdio.h>

int main(void) 
{
  double r, c;
  scanf("%lf", &r);
  c = 3.14159 * r * r;
  // double c = Math.PI * Math.Pow(r,2);
  printf("A=%.4lf\n", c);
  return 0;
}
