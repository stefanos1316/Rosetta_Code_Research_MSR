#include <iostream>

unsigned int ackermann(unsigned int m, unsigned int n) {
  if (!m) return n + 1;
  if (!n) return ackermann(m - 1, 1);
  return ackermann(m - 1, ackermann(m, n - 1));
}

int executeTask(int i) {
  for (unsigned int m = 0; m <= 3; ++m) {
    for (unsigned int n = 0; n <= 3; ++n) {
    	ackermann(m, n);
    }
 }
  return i + 1;
}

int main() {

  	volatile int r = 1;
  	for (int i = 0; i < 1000000; ++i) {
  		r = executeTask(i + r);
	}

}
