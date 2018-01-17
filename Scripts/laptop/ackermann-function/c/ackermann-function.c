#include <stdio.h>

int ackermann(int m, int n)
{
        if (!m) return n + 1;
        if (!n) return ackermann(m - 1, 1);
        return ackermann(m - 1, ackermann(m, n - 1));
}

int main()
{
	volatile int r = 0;
        int m, n;
        for (int i = 0; i < 1000000; ++i) {

        for (m = 0; m <= 3; m++)
                for (n = 0; n <= 3; n++)
                     r = ackermann(m, n);
        }
        return 0;
}
