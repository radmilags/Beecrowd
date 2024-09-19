#include <stdio.h>

int main() {
    int N;

    scanf("%d", &N);

    for (int a = 1; a <= N; a++) {
        if (N % a == 0) {
            printf("%d\n", a);
        }
    }

    return 0;
}