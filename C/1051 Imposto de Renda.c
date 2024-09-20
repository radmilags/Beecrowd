#include <stdio.h>
 
int main() {
    double a, x = 0;
    scanf("%lf", &a);

    if (a >= 0 && a <= 2000)
    {
      printf("Isento\n");
    }
    else if (a >= 2000.01 && a <= 3000)
    {
      a -= 2000;
      x = a*0.08;
      printf("R$ %.2lf\n", x);
    }
    else if (a >= 3000.01 && a <= 4500)
    {
      a -= 3000;
      x = a*0.18+80;
      printf("R$ %.2lf\n", x);
    }
    else
    {
      a -= 4500;
      x = a*0.28+350;
      printf("R$ %.2lf\n", x);
    }
    return 0;
}