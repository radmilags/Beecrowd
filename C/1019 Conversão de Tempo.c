#include <stdio.h>

int main(void) 
{
  int n, a, b, c, d;
  scanf("%d", &n);
  a = n/3600;
  b = n%3600;
  c = b / 60;
  d = b%60;
  printf("%d:%d:%d\n", a, c, d);
  return 0;
}
