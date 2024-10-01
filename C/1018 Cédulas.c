#include <stdio.h>

int main(void) 
{
  int a;
  scanf("%d", &a);
  printf("%d\n", a);
  int cem = a /100;
  a = a - cem *100;
  int cin = a / 50;
  a = a - cin * 50;
  int vin = a / 20;
  a = a - vin * 20;
  int dez = a/10;
  a = a - dez * 10;
  int cinc = a/5;
  a = a - cinc * 5;
  int dois = a/2;
  a = a - dois * 2;
  int um = a/1;

  printf("%d nota(s) de R$ 100,00\n", cem);
  printf("%d nota(s) de R$ 50,00\n", cin);
  printf("%d nota(s) de R$ 20,00\n", vin);
  printf("%d nota(s) de R$ 10,00\n", dez);
  printf("%d nota(s) de R$ 5,00\n", cinc);
  printf("%d nota(s) de R$ 2,00\n", dois);
  printf("%d nota(s) de R$ 1,00\n", um);
  return 0;
}
