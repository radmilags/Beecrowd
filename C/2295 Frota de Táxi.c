#include <stdio.h>

int main(void) 
{
  double a, g, ra, rg;
  scanf("%lf%lf%lf%lf", &a, &g, &ra, &rg);
  if((a == g && ra == rg) || ra/a <= rg/g) printf("G\n");
  else printf("A\n");
  return 0;
}