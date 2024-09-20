#include <stdio.h>
 
int main() {
    double a, b, c, d, e, f;
    scanf("%lf", &a);
    scanf("%lf", &b);
    scanf("%lf", &c);
    scanf("%lf", &d);
    scanf("%lf", &e);
    scanf("%lf", &f);
    int i = 0;
    if (a > 0) i++;
    if (b > 0) i++;
    if (c > 0) i++;
    if (d > 0) i++;
    if (e > 0) i++;
    if (f > 0) i++;
    printf("%d valores positivos\n", i);
    return 0;
}