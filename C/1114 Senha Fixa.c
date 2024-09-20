#include <stdio.h>
 
int main() {
 int a;
    do 
    {
      scanf("%d", &a);
      if (a != 2002) printf("Senha Invalida\n");
      else printf("Acesso Permitido\n");
    } while(a != 2002);
    return 0;
}