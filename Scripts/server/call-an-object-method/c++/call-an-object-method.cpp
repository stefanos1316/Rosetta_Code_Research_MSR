#include <iostream>

using namespace std;

class someMethod {
		volatile int setNumber;
	public:	
		void setValue(int );
};

void someMethod::setValue (int value) {
	setNumber = value;
}


int executeTask(int i) {
	someMethod objectCall;
	objectCall.setValue(100);
	return i + 1;
}

int main () {
	volatile int r = 1;
	for (int i = 0; i < 2000000000; ++i)
		r = executeTask(i + r);
	return 0;
}
