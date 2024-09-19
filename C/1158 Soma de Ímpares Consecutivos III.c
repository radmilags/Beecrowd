#include <stdio.h>

int main(void) 
{
  int x = 0, n, i, j, a, b;
  scanf("%d", &n);
  for(i = 1; i <= n; i++)
    {
      scanf("%d %d", &a, &b);
      for(j = 1; j <= b; j++)
      {
        if(a % 2 != 0) x += a;
        else { a++; x += a;}
        a += 2;
      }
      printf("%d\n", x);
      x = 0;
    }
  return 0;
}