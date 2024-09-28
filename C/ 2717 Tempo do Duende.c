#include <stdio.h>
 
int main() {
 int a, b, c;
 scanf("%d", &c);
 scanf("%d %d", &a, &b);
 if(c % (a+b) == 0) printf("Farei hoje!\n");
 else printf("Deixa para amanha!\n");
    return 0;
}