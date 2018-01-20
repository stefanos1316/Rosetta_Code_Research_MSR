#include <iostream>

using namespace std;
 
template <typename T1, typename T2>
int* concatArrays( T1& array_1, T2& array_2) {
  int arrayCount_1 = sizeof(array_1) / sizeof(array_1[0]);
  int arrayCount_2 = sizeof(array_2) / sizeof(array_2[0]);
  int newArraySize = arrayCount_1 + arrayCount_2;
 
  int *p = new int[newArraySize];
 
  for (int i = 0; i < arrayCount_1; i++) {
  	p[i] = array_1[i];
  }
 
  for (int i = arrayCount_1; i < newArraySize; i++) {
	int newIndex = i-arrayCount_2;
	p[i] = array_2[--newIndex];
  }
 
  return p;
}
 
int executeTask(int i) {
  int ary[5] = {1+i, 2-i, 3+i, 4-i, 5+i};
  int anotherAry[5] = {6+i, 7-i, 8+i, 9-i, 10+i};

  int *r = concatArrays(ary, anotherAry);
  delete r;
  return i;
}

int main() {

  volatile int r = 1;
  for ( int j=0; j < 2000000000; ++j) {
	r = executeTask(j);
  }

  return 0;
}
