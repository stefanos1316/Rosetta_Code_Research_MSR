#include <stdlib.h>

typedef struct sMyClass
{
  int variable;
} *MyClass;

MyClass  MyClass_new()
{
  MyClass pthis = malloc(sizeof *pthis);
  pthis->variable = 0;
  return pthis;
}


void MyClass_someMethod(MyClass pthis, int i)
{
  int value = pthis->variable + i;
}

int executeTask(MyClass obj, int i) {
	MyClass_someMethod(obj, i);
	return i;
}

int main() {
	volatile int r = 1;
	volatile MyClass obj = MyClass_new();
	for (int i = 0; i < 2000000000; ++i) {
		r = executeTask(obj, i);
	}

return 0;
}
