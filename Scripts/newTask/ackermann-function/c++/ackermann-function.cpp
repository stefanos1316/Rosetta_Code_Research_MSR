#include <iostream>

unsigned int ackermann(unsigned int m, unsigned int n) {
  if (!m) return n + 1;
  if (!n) return ackermann(m - 1, 1);
  return ackermann(m - 1, ackermann(m, n - 1));
}

int main() {
  for (int i = 0; i < 50; ++i) {
  for (unsigned int m = 0; m <= 4; ++m) {
    for (unsigned int n = 0; n < 6 - m; ++n) {
      //std::cout << "A(" << m << ", " << n << ") = " << ackermann(m, n) << "\n";
      ackermann(m, n);
    }
  }
}
}
