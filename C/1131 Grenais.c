#include <stdio.h>

int main(void) 
{
  int inter, gremio;
  scanf("%d %d", &inter, &gremio);

  int it = 0; 
  int gr = 0; 
  int g = 0; 
  int i = 0;
  int e = 0;

    if (inter > gremio) it++;
    else gr++;
    if (inter == gremio) e++;

    do
    {
    printf("Novo grenal (1-sim 2-nao)\n");
    scanf("%d", &g);
    if (g == 1) 
    {
      scanf("%d %d", &inter, &gremio);
      if (inter > gremio) it++;
      else gr++;
      if (inter == gremio) e++;
    }
    i++;
    } while(g != 2);

    printf("%d grenais\n", i);
    printf("Inter:%d\n", it);
    printf("Gremio:%d\n", gr);
    printf("Empates:%d\n", e);
    if (it > e) printf("Inter venceu mais\n");
    else printf("Gremio venceu mais\n");
  return 0;
}
