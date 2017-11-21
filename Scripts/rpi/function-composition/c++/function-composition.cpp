#include <iostream>
#include <cmath>
#include <ext/functional>

int main() {
  for (int i = 0; i < 100000000; ++i) {
     __gnu_cxx::compose1(std::ptr_fun(::sin), std::ptr_fun(::asin))(0.5);
  }
  return 0;
}
