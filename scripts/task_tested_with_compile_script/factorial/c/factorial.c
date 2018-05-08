#include <stdio.h>


int main() {

volatile int result;

for (int i = 0; i < 100000; ++i) {
	result = executeTask(i);
}

return 0;
}

int executeTask(int i){
		return factorial(i);
}

int factorial(int n) {
    return n == 0 ? 1 : n * factorial(n - 1);
}
