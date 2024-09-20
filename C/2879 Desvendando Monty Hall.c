#include <stdio.h>
 
int main() {
 int n, x, i;
  scanf("%d", &n);
  x = n;
  for(i = 1; i <= n; i++)
  {
    int a;
    scanf("%d", &a);
    if(a == 1) x--;
  }
  printf("%d\n", x);
  return 0;
}