#include <stdio.h>
 
int main() {
 double a, b, c, d, e, f, x;
 int i = 0;
 scanf("%lf", &a);
 scanf("%lf", &b);
 scanf("%lf", &c);
 scanf("%lf", &d);
 scanf("%lf", &e);
 scanf("%lf", &f);
 if(a > 0) {x += a; i++;}
 if(b > 0) {x += b; i++;}
 if(c > 0) {x += c; i++;}
 if(d > 0) {x += d; i++;}
 if(e > 0) {x += e; i++;}
 if(f > 0) {x += f; i++;}
 printf("%d valores positivos\n", i);
 printf("%.1lf\n", x/i);
    return 0;
}