#include <stdio.h>

int main(void) 
{
  int a, b, c, d, x;
  scanf("%d %d", &a, &b);
  scanf("%d %d", &c, &d);
  x = a * b - c * d;
  printf("DIFERENCA = %d\n", x);
  return 0;
}