#include <stdio.h>

int factorial(int n);

int main() {

for (int i = 0; i < 1000000000; ++i) {
int result = factorial(10);
}

return 0;
}

int factorial(int n) {
    return n == 0 ? 1 : n * factorial(n - 1);
}