#include <stdio.h>

int main()
{
    double a;
    double b;
    double s;
    scanf("%lf", &a);
    scanf("%lf", &b);
    s = (a * 3.5) + (7.5 * b);
    s = s/11;
    printf("MEDIA = %2.5lf\n", s);
    return 0;
}
