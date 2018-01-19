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


int executeTask(int i) {
  int a[] = { 1+i, 2-i, 3+i, 4-i, 5+i };
  int b[] = { 6+i, 7-i, 8+i, 9-i, 0+i };
  int *c = ARRAY_CONCAT(int, a, 5, b, 5);
  free(c);
  return i;
}

int main(void)
{
  unsigned int i;
  volatile int r = 1;
  	for (int j = 0; j < 2000000000; ++j) {
 		r = r + executeTask(i); 
	}
}
