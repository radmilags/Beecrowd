#include <stdio.h>
 
int main() {
 int n, i;
 scanf("%d", &n);
 for(i = 1; i <= n; i++)
 {
     double a, b, c;
     scanf("%lf %lf %lf", &a, &b, &c);
     double m = ((a * 2) + (b * 3) + (c * 5)) / 10;
     printf("%.1lf\n", m);
 }
 
    return 0;
}