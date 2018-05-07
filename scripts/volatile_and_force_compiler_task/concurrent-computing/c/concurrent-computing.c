#include <stdio.h>
#include <omp.h>


int executeTask(int j){
	const char *str[] = { "Enjoy", "Rosetta", "Code" };
	for (int i = 0; i < 3; i++)
		printf("%d %s \n",j, str[i]);
	return j;
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
