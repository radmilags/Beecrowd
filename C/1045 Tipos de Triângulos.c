#include <stdio.h>

int main(void) 
{
  double a, b, c;
  scanf("%lf %lf %lf", &a, &b, &c);
  double m;
    if(a < b)
    {
      m = a;
      a = b;
      b = m;

    }
     if(a < c)
    {
      m = a;
      a = c;
      c = m;

    }
     if(b < c)
    {
      m = b;
      b = c;
      c = m;

    }

    if (a >= b + c) printf("NAO FORMA TRIANGULO\n");
    else if (a * a == b * b + c * c) printf("TRIANGULO RETANGULO\n");
    else if (a * a > b * b + c * c) printf("TRIANGULO OBTUSANGULO\n");
    else if (a * a < b * b + c * c) printf("TRIANGULO ACUTANGULO\n");
    if (a == b && b == c) printf("TRIANGULO EQUILATERO\n");
    else if (a == b || b == c) printf("TRIANGULO ISOSCELES\n");
  return 0;
}
