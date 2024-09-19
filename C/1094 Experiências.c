#include <stdio.h>

int main(void) 
{
  int r = 0, s = 0, c = 0, x = 0, n, i, a; char b;
  scanf("%d", &n);
  for(i = 1; i <= n; i++)
  {
    scanf("%d %c", &a, &b);
    x += a;
    if(b == 'C') c += a;
    if(b == 'S') s += a;
    if(b == 'R') r += a;
  }
  double pc = c*100.0/x;
  double ps = s*100.0/x;
  double pr = r*100.0/x;

  printf("Total: %d cobaias\n", x);
  printf("Total de coelhos: %d\n", c);
  printf("Total de ratos: %d\n", r);
  printf("Total de sapos: %d\n", s);
  printf("Percentual de coelhos: %1.2lf %%\n", pc);
  printf("Percentual de ratos: %1.2lf %%\n", pr);
  printf("Percentual de sapos: %1.2lf %%\n", ps);

  return 0;
}