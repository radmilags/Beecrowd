#include <stdio.h>

int main(void) 
{
  int soma = 0;
    int n, i; scanf("%d", &n);
    while (n != 0)
    {
        int x = n;
        if (x % 2 != 0) x++; soma += x;
        for (i = 1; i <= 4; i++)
        {
            x += 2;
            soma += x;
        }
        printf("%d\n", soma);
        soma = 0; x = 0; n = 0;
        scanf("%d", &n);
    }
  return 0;
}