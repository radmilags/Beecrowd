#include <stdio.h>
#include <math.h>
int main(void) 
{
  double v, d;
  while(scanf("%lf", &v) != EOF)
  {
    scanf("%lf", &d);
    double r = d/2;
    double a = 3.14 * pow(r,2);
    double h = v/a;
    printf("ALTURA = %1.2lf\n", h);
    printf("AREA = %1.2lf\n", a);
  }
  return 0;
}