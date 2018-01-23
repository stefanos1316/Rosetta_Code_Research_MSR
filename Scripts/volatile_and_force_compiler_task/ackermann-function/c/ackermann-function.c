#include <stdio.h>

int ackermann(int m, int n)
{
        if (!m) return n + 1;
        if (!n) return ackermann(m - 1, 1);
        return ackermann(m - 1, ackermann(m, n - 1));
}

int executeTask(int i) {
	int m, n;
        for (m = 0; m <= 3; m++)
                for (n = 0; n <= 3; n++)
	        	ackermann(m, n);
}

int main()
{
	volatile int r = 0;
        for (int i = 0; i < 1000000; ++i) {
		r = executeTask(i) + i;
	}
        return 0;
}
