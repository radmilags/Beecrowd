#include <stdio.h>

int main(void) 
{
  char s[100];
  scanf("%s", s);
  double a, b, x;
  scanf("%lf %lf", &a, &b);
  x = (b/100*15) + a;
  printf("TOTAL = R$ %.2lf\n", x);

  return 0;
}