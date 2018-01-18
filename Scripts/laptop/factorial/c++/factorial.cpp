#include <iostream>

int factorial(int);

int executeTask(int i) {
	return factorial(10)  +i;
}

int main() {

volatile int r = 1;
for (int i = 0; i < 2000000000; ++i) {	
	r =executeTask(i + r);
}
	return 0; 	
}

int factorial(int number) {
	int temp;

	if(number <= 1) return 1;

	temp = number * factorial(number - 1);
	return temp;
}

