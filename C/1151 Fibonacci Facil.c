#include <stdio.h>
int main(void)
{
  int a=0, b=1, c=0, n, i = 1;
  scanf("%d",&n);
  for(; i < n; i++)
  {
    printf("%d ",a);
    c=a+b;
    a = b;
    b = c;
  }
  printf("%d\n",a);
}