#include <stdio.h>
 
int main() {
    int a, b, c, d, e;
    scanf("%d %d %d %d %d", &a, &b, &c, &d, &e);
    int x = 0; //números positivos
    int y = 0; //números negativos
    int w = 0; //números pares
    int z = 0; //números ímpares

    if (a > 0) x++;
    else y++;
    if (b > 0) x++;
    else y++;
    if (c > 0) x++;
    else y++;
    if (d > 0) x++;
    else y++;
    if (e > 0) x++;
    else y++;

    if (a == 0) y--;
    if (b == 0) y--;
    if (c == 0) y--;
    if (d == 0) y--;
    if (e == 0) y--;

    if (a%2 == 0) w++;
    else z++;
    if (b%2 == 0) w++;
    else z++;
    if (c%2 == 0) w++;
    else z++;
    if (d%2 == 0) w++;
    else z++;
    if (e%2 == 0) w++;
    else z++;

    printf("%d valor(es) par(es)\n", w);
    printf("%d valor(es) impar(es)\n", z);
    printf("%d valor(es) positivo(s)\n", x);
    printf("%d valor(es) negativo(s)\n", y);
    return 0;
}