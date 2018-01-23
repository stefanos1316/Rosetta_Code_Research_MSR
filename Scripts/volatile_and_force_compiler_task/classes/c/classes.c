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

void MyClass_delete(MyClass* pthis)
{
  if (pthis)
  {
    free(*pthis);
    *pthis = NULL;
  }
}

void MyClass_someMethod(MyClass pthis, int i)
{
  pthis->variable = 1 + i;
}


int executeTask(int i){

	MyClass obj1 = MyClass_new();
	MyClass_someMethod(obj1, i);
	MyClass_delete(&obj1);
	return i;
}


int main() {
volatile int r = 1;
for (int i = 0; i < 2100000000; ++i) {
	r = executeTask(i + r);
}

return 0;
}
