#include <stdio.h>
 
int main() {
 int a, b, x = 0, i = 0;
 scanf("%d", &a);
 scanf("%d", &b);
    if (a > b) 
    {
      for (i = b; i <= a; i++)
      {
        if (i % 13 != 0)
        x += i;
      }
    }
    else
    {
      for (i = a; i <= b; i++)
      {
        if (i % 13 != 0)
        x += i;
      }
    }
    printf("%d\n", x);
    return 0;
}