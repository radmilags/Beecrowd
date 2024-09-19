#include <stdio.h>

int main(void) 
{
  int a, b, c, x = 0, w = 0, z = 0;
  scanf("%d%d%d", &a, &b, &c);
  w = (b*2)+(c*4);
  x = (c*2)+(a*2);
  z = (b*2)+(a*4);
  if(w <= x && w <= z) printf("%d\n", w);
  else if(x <= w && x <= z) printf("%d\n", x);
  else if(z <= x && z <= w) printf("%d\n", z);
  return 0;
}