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

void MyClass_someMethod(MyClass pthis)
{
  pthis->variable = 1;
  printf("Variable value is %d\n", &pthis->variable);
}

int main() {
volatile MyClass obj = MyClass_new();

for (int i = 0; i < 1000000; ++i) {
	MyClass obj1 = MyClass_new();
	MyClass_someMethod(obj1);
	MyClass_delete(&obj1);
}

return 0;
}
