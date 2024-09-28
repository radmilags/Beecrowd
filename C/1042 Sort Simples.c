#include <stdio.h>

int main(void) 
{
  int a, b, c;
  scanf("%d %d %d", &a, &b, &c);
  int x = a;
  int y = b;
  int z = c;

  int m;
  if(a > b)
  {
    m = a;
    a = b;
    b = m;
  }
  if(a > c)
  {
    m = a;
    a = c;
    c = m;
  }
  if(b > c)
  {
    m = b;
    b = c;
    c = m;
  }

  printf("%d\n%d\n%d\n\n%d\n%d\n%d\n", a, b, c, x, y, z);
  return 0;
}