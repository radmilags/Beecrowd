#include <stdio.h>

int main(void) 
{
  int n, i;
  do
    {
      scanf("%d", &n);
      if(n != 0)
      {
        for(i = 1; i <= n; i++)
        {
          if(i == n) printf("%d\n", i);
          else printf("%d ", i);
        }
      }
    }while (n != 0);
  return 0;
}