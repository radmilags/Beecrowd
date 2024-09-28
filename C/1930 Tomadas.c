#include <stdio.h>

int main(void) 
{
  int a, b, c, d, e;
  scanf("%d %d %d %d", &a, &b, &c, &d);
  a -= 1; b -= 1; c -= 1; e = a + b + c + d;
  printf("%d\n", e);
  return 0;
}
