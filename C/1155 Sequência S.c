#include <stdio.h>

int main(void) 
{
  double s = 0, x, i;
  for(i = 1; i <= 100; i++)
  {
    x = 1/i;
    s += x;
  }
  printf("%1.2lf\n", s);
  return 0;
}