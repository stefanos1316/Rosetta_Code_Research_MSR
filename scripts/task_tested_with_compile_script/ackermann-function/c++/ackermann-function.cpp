#include <iostream>

unsigned int ackermann(unsigned int m, unsigned int n) {
  if (!m) return n + 1;
  if (!n) return ackermann(m - 1, 1);
  return ackermann(m - 1, ackermann(m, n - 1));
}

int executeTask(int i) {

  int aVar = 0;
  if (i % 2 == 0)
	aVar = 1;
  else
	aVar = 2;

  for (unsigned int m = 0; m <= 4 - aVar; ++m) {
    for (unsigned int n = aVar; n <= 3; ++n) {
    	ackermann(m, n);
    }
 }
  return i;
}

int main() {

  	volatile int r = 1;
  	for (int i = 0; i < 10000000; ++i) {
  		r = executeTask(i);
	}

}
