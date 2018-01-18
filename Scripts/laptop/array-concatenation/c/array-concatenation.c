#include <stdlib.h>
#include <stdio.h>
#include <string.h>

#define ARRAY_CONCAT(TYPE, A, An, B, Bn) \
  (TYPE *)array_concat((const void *)(A), (An), (const void *)(B), (Bn), sizeof(TYPE));

void *array_concat(const void *a, size_t an,
                   const void *b, size_t bn, size_t s)
{
  char *p = malloc(s * (an + bn));
  memcpy(p, a, an*s);
  memcpy(p + an*s, b, bn*s);
  return p;
}

// testing
const int a[] = { 1, 2, 3, 4, 5 };
const int b[] = { 6, 7, 8, 9, 0 };

int executeTask(int i) {
  int *c = ARRAY_CONCAT(int, a, 5, b, 5);
  free(c);
  return i+1;
}

int main(void)
{
  unsigned int i;
  volatile int r = 1;
  	for (int j = 0; j < 2000000000; ++j) {
 		r = r + executeTask(i); 
	}
}
