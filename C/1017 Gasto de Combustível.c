#include <stdio.h>

int main(void) 
{
  int h, vm;
  double l, d;
  scanf("%d", &h);
  scanf("%d", &vm);
  d = h*vm;
  l = d/12;
  printf("%1.3lf\n", l);
  return 0;
}
