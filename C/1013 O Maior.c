#include <stdio.h>
 
int main() {
 int a, b, c;
 scanf("%d %d %d", &a, &b, &c);
 int maiorab = (a+b+abs(a-b))/2;
 int maiorabc = (maiorab + c + abs(maiorab-c))/2;
 printf("%d eh o maior\n", maiorabc);
    return 0;
}