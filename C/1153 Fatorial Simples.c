#include <stdio.h>

int main(void) 
{
  int x = 1, n, i;
  scanf("%d", &n);
  for( i = n; i >= 1; i--) x *= i;
  printf("%d\n", x);
  return 0;
}