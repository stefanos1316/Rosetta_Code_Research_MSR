#include <stdio.h>

int factorial(int n);

int main() {

volatile int result;

for (int i = 0; i < 2000000000; ++i) {
	result = executeTask(i + result);
}

return 0;
}

int executeTask(int i){
	factorial(10);
	return i;
}

int factorial(int n) {
    return n == 0 ? 1 : n * factorial(n - 1);
}
