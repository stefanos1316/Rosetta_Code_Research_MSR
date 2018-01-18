#include <stdio.h>
#include <omp.h>


int executeTask(int i){
	const char *str[] = { "Enjoy", "Rosetta", "Code" };
	for (int i = 0; i < 3; i++)
		printf("%s\n", str[i]);
	return i;
}

int main()
{
	volatile int r;
	#pragma omp parallel for num_threads(3)
	for ( int j = 0; j < 1000000; ++j) {
		r = executeTask(j);
	}
	return 0;
}
