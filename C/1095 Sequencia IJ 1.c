#include <stdio.h>

int main(void) 
{
  int i = 1; int j = 60;
  while(j != 0)
  {
    printf("I=%d J=%d\n", i, j);
    i += 3; j -= 5;
    if (j == 0) printf("I=%d J=%d\n", i, j);
  }
  return 0;
}
