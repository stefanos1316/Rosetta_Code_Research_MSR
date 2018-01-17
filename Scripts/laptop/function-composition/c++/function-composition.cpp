#include <iostream>
#include <cmath>
#include <ext/functional>

int main() {
 volatile double r = 0; 

 for (int i = 0; i < 1000000000; ++i) {
     r = __gnu_cxx::compose1(std::ptr_fun(::sin), std::ptr_fun(::asin))(i);
  }
  return 0;
}
