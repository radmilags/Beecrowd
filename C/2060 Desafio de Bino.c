#include <stdio.h>

int main(void) 
{
  int n, a, d = 0, q = 0, t = 0, c = 0, i;
  scanf("%d", &n);
  for(i = 1; i <= n; i++)
  {
    scanf("%d", &a);
    if(a % 2 == 0) d++;
    if(a % 3 == 0) t++;
    if(a % 4 == 0) q++;
    if(a % 5 == 0) c++;
  }
  printf("%d Multiplo(s) de 2\n", d);
  printf("%d Multiplo(s) de 3\n", t);
  printf("%d Multiplo(s) de 4\n", q);
  printf("%d Multiplo(s) de 5\n", c);
  return 0;
}