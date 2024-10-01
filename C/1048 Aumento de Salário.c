#include <stdio.h>

int main(void) 
{
  double a, x = 0, y = 0;
  scanf("%lf", &a);
  if (a == 400.00)
    {
      y = a/100*15;
      x = y+a;
      printf("Novo salario: %.2lf\n", x);
      x -= a;
      printf("Reajuste ganho: %.2lf\n", x);
      printf("Em percentual: 15 %%\n");
    }
    else if (a > 400.00 && a < 800.01)
    {
      y = a/100*12;
      x = y+a;
      printf("Novo salario: %.2lf\n", x);
      x -= a;
      printf("Reajuste ganho: %.2lf\n", x);
      printf("Em percentual: 12 %%\n");
    }
    else if (a > 800.00 && a < 1200.01)
    {
      y = a/100*10;
      x = y+a;
      printf("Novo salario: %.2lf\n", x);
      x -= a;
      printf("Reajuste ganho: %.2lf\n", x);
      printf("Em percentual: 10 %%\n");
    }
    else if (a > 1200.00 && a < 2000.01)
    {
      y = a/100*7;
      x = y+a;
      printf("Novo salario: %.2lf\n", x);
      x -= a;
      printf("Reajuste ganho: %.2lf\n", x);
      printf("Em percentual: 7 %%\n");
    }
    else if (a > 2000.00)
    {
      y = a/100*4;
      x = y+a;
      printf("Novo salario: %.2lf\n", x);
      x -= a;
      printf("Reajuste ganho: %.2lf\n", x);
      printf("Em percentual: 4 %%\n");
    }

  return 0;
}
