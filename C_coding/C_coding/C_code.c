#include <stdio.h>
#pragma warning(disable : 4996)
int main() {
    int numbers[5], i;
    //int size = sizeof(numbers) / sizeof(numbers[0]);

    printf("Elements of the array:\n");
    for (i = 0; i < 5; i++)
        scanf("%d", &numbers[i]);

    for (i = 0; i < 5; i++) {
        printf("%d\n ", numbers[i]);
    }


}

