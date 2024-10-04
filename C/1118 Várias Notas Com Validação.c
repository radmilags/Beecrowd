#include <stdio.h>
 
int main() 
{
    int op, x = 0;
    double soma = 0.0, a;
    do
    {
        do
        {
          scanf("%lf", &a);
          if(a >= 0 && a <= 10) {soma += a; x++;}
          else printf("nota invalida\n");
        }
        while(x != 2);
        printf("media = %.2lf\n", soma/2);
      do
      {
        printf("novo calculo (1-sim 2-nao)\n");
        scanf("%d", &op);
      }while(op != 1 && op != 2);
      soma = 0; x = 0;
    } while (op == 1);
    return 0;
}
