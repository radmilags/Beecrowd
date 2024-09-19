#include <stdio.h>
 
int main() {
    double A, B, C, R1, R2;
    scanf("%lf %lf %lf", &A, &B, &C);
    double d = (B * B) - 4*A*C;
    if (A == 0 || d < 0)
    {
      printf("Impossivel calcular\n");
    }
    else if (d == 0)
    {    
      double r  = sqrt(d);
      R1 = (-B + r) / (2 * A);
      printf("R1 = %1.5lf\n", R1);
      printf("R2 = %1.5lf\n", R1);
    }
    else
    {
      double r  = sqrt(d);
      R1 = (-B + r) / (2 * A);
      R2 = (-B - r) / (2 * A);
      printf("R1 = %1.5lf\n", R1);
      printf("R2 = %1.5lf\n", R2);
    }
    return 0;
}