#include <iostream>

class MyClass
{
public:
  void someMethod(); // member function = method
  MyClass(); // constructor
private:
 volatile int variable; // member variable = instance variable
};

MyClass::MyClass():
  variable(0)
{
  // here could be more code
}

void MyClass::someMethod()
{
  variable = 1; // alternatively: this->variable = 1
}

int executeTask(int i) {
	MyClass* pInstance = new MyClass();
	pInstance->someMethod();
	delete pInstance;

	return i + 1;
}

int main(){

	volatile int r = 0;
	for (int i = 0; i < 2000000000; ++i) {
		r = executeTask(i + r);
	}
}
