#include <stdio.h>

int main(void) 
{
  int a, b, c, a2, b2, c2;
  scanf("%d %d %d", &a, &b, &c);
  a2 = a * a; b2 = b * b; c2 = c * c;
  if (a >= b + c || b >= a + c || c >= a + b)
  printf("n\n");
  else if (a2 == b2+c2 || b2 == a2+c2 || c2 == a2+b2)
  printf("r\n");
  else if (a2>b2+c2 || b2>a2+c2 || c2>a2+b2)
  printf("o\n");
  else
  printf("a\n");
  return 0;
}