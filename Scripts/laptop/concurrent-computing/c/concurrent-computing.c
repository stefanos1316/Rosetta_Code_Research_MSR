#include <stdio.h>
#include <omp.h>

int main()
{

	const volatile char *str[] = { "Enjoy", "Rosetta", "Code" };
	#pragma omp parallel for num_threads(3)
	for ( int j = 0; j < 1000000; ++j) {
		for (int i = 0; i < 3; i++)
			printf("%s\n", str[i]);
	}
	return 0;
}
