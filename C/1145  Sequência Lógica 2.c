#include <stdio.h>
 
int main() {
 int v1, v2, x;
    scanf("%d %d", &v1, &v2);
    for (x = 1; x <= v2; x++)
    {
      if (x % v1 == 0) printf("%d\n", x);
      else printf("%d ", x);
    }
    return 0;
}