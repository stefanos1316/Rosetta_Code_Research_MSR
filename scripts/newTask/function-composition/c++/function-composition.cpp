#include <iostream>
#include <cmath>
#include <ext/functional>

int main() {
  volatile double k = 0.5;
  volatile double r;

  for (double i = 0; i < 1000000000; ++i) {
     r = __gnu_cxx::compose1(std::ptr_fun(::sin), std::ptr_fun(::asin))(i);
  }
  return 0;
}
