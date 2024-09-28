#include <stdio.h>

int main(void) 
{
  int n, a, b, c, d, e; int i = 0;
  scanf("%d", &n);
  scanf("%d %d %d %d %d", &a, &b, &c, &d, &e);
  if (a == n) i++;
  if (b == n) i++;
  if (c == n) i++;
  if (d == n) i++;
  if (e == n) i++;
  printf("%d\n", i);
  return 0;
}
