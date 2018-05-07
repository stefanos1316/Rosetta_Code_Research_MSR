#include <iostream>

int factorial(int);

int executeTask(int i) {
		return factorial(i);
}

int main() {

volatile int r = 1;
for (int i = 0; i < 100000; ++i) {	
	r =executeTask(i);
}
	return 0; 	
}

int factorial(int number) {
	int temp;

	if(number <= 1) return 1;

	temp = number * factorial(number - 1);
	return temp;
}

