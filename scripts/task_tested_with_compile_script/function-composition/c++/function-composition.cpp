#include <iostream>
#include <cmath>
#include <ext/functional>

double executeTask(int i) {
	
	 return __gnu_cxx::compose1(std::ptr_fun(::sin), std::ptr_fun(::asin))(i); ;
}

int main() {
  volatile double r = 0; 

  for (int i = 0; i < 1000000000; ++i) {
  	r = executeTask(i); 
  }
  return 0;
}
