#include <stdio.h>
int main(){
    int n, a, b;
    scanf("%d", &n);
    int copos = 0;
    for(int i = 0; i < n; i++){
        scanf("%d %d", &a, &b);
        if(a > b) copos += b;
    }
    printf("%d\n", copos);
}