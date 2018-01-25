#include <stdio.h>

int ackermann(int m, int n)
{
        if (!m) return n + 1;
        if (!n) return ackermann(m - 1, 1);
        return ackermann(m - 1, ackermann(m, n - 1));
}

int executeTask(int i) {
	int m, n, aVar;
	if (i % 2 ==0 ) 
		aVar = 1;
	else
		aVar = 2; 

        for (m = 0; m <= 4 - aVar; m++)
                for (n = aVar; n <= 3; n++)
	        	ackermann(m, n);
}

int main()
{
	volatile int r = 0;
        for (int i = 0; i < 10000000; ++i) {
		r = executeTask(i) + i;
	}
        return 0;
}
