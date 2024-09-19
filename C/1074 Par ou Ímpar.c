#include <stdio.h>

int main(void) 
{
  int n, i, a; char s[9], x;
  scanf("%d", &n);
  for(i = 1; i <= n; i++)
  {
    scanf("%d", &a);
    if(a == 0) printf("NULL\n");
    else if(a <= 0 && a%2== 0) printf ("EVEN NEGATIVE\n");
    else if(a <= 0 && a%2 != 0) printf ("ODD NEGATIVE\n");
    else if(a >= 0 && a%2 == 0) printf ("EVEN POSITIVE\n");
    else if(a >= 0 && a%2 == 1) printf ("ODD POSITIVE\n");
  }
  return 0;
}