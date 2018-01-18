#include <iostream>

template<typename Number>
 Number power(Number base, int exponent)
{
  int zerodir;
  Number factor;
  if (exponent < 0)
  {
    zerodir = 1;
    factor = Number(1)/base;
  }
  else
  {
    zerodir = -1;
    factor = base;
  }

  Number result(1);
  while (exponent != 0)
  {
    if (exponent % 2 != 0)
    {
      result *= factor;
      exponent += zerodir;
    }
    else
    {
      factor *= factor;
      exponent /= 2;
    }
  }
  return result;
}

int executeTask(int i) {
	power(2017,12 + i);
	power(19.88,12 + i);

	return 1 + i;
}

int main() {

volatile int r = 1;  

for ( int i = 0; i < 1000000000; ++i ) {
	r = executeTask(i + r);
}

}
