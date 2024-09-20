#include <stdio.h>
 
int main() {
 int a, b;
 scanf("%d %d", &a, &b);
 
    double x = 0;

    switch (a)
    {
      case 1:
      x = b*4.0;
      printf("Total: R$ %.2lf\n", x);
      break;
      case 2:
      x = b*4.50;
      printf("Total: R$ %.2lf\n", x);
      break;
      case 3:
      x = b*5.0;
      printf("Total: R$ %.2lf\n", x);
      break;
      case 4:
      x = b*2.0;
      printf("Total: R$ %.2lf\n", x);
      break;
      case 5:
      x = b*1.50;
      printf("Total: R$ %.2lf\n", x);
      break;
    }
}