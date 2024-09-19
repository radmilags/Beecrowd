#include <stdio.h>
int mdc(int F1, int F2)
{
    int a = F1, b = F2, c;
    if (a < b) { a = F2; b = F1; }
    c = a % b;
    while (c != 0)
    { a = b; b = c; c = a % b; }
    return b;
}
int main(void) 
{
  int n, i; scanf("%d", &n);
  for(i = 1; i <= n; i++)
  {
    int a, b; scanf("%d %d", &a, &b);
    printf("%d\n", mdc(a, b));
  }
  return 0;
}