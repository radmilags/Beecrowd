#include <stdio.h>

int main(void) 
{
  double T, CIR, TRA, Q, R, A, B, C;
  scanf("%lf %lf %lf", &A, &B, &C);
  T = A*C/2;
  CIR = 3.14159*(C*C);
  TRA = (A+B)*C/2;
  Q = B*B;
  R = A*B;
  printf("TRIANGULO: %1.3lf\n", T);
  printf("CIRCULO: %1.3lf\n", CIR);
  printf("TRAPEZIO: %1.3lf\n", TRA);
  printf("QUADRADO: %1.3lf\n", Q);
  printf("RETANGULO: %1.3lf\n", R);
  return 0;
}
