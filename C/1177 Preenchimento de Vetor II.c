#include <stdio.h>
 
int main() 
{
     int x, j = 0, i;
     scanf("%d", &x);
     for(i = 0; i < 1000; i++)
     {
         printf("N[%d] = %d\n", i, j);
         j++;
         if (j == x) j = 0;
     }
    return 0;
}