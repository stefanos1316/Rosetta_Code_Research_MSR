#include <iostream>

int factorial(int);

int main() {
volatile int j;

for (int i = 0; i < 1000000000; ++i) {	
	j = factorial(10);
}
	return 0; 	
}

int factorial(int number) {
	int temp;

	if(number <= 1) return 1;

	temp = number * factorial(number - 1);
	return temp;
}

