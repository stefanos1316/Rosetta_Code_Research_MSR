#include <iostream>

using namespace std;

class someMethod {
		volatile int setNumber;
	public:	
		void setValue(int , int);
};

void someMethod::setValue (int value, int i) {
	setNumber = value + i;
}


int executeTask(int i) {
	someMethod objectCall;
	objectCall.setValue(100, i);
	return i;
}

int main () {
	volatile int r = 1;
	for (int i = 0; i < 2000000000; ++i)
		r = executeTask(i );
	return 0;
}
