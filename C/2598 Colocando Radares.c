#include <stdio.h>

int main(void) 
{
  int a; scanf("%d", &a);
  while(a--)
  {
    int m,n;
    scanf("%d%d", &m, &n);
    if(m < n) printf("1\n");
    else if(m % n == 0) printf("%d\n", m/n);
    else printf("%d\n", (m/n) + 1);
 }
  return 0;
}