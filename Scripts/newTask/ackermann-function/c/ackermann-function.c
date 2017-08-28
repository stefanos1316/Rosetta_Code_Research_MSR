#include <stdio.h>

int ackermann(int m, int n)
{
        if (!m) return n + 1;
        if (!n) return ackermann(m - 1, 1);
        return ackermann(m - 1, ackermann(m, n - 1));
}

int main()
{
        int m, n;

        for (int i = 0; i < 50; ++i) {

        for (m = 0; m <= 4; m++)
                for (n = 0; n < 6 - m; n++)
                     ackermann(m, n);
        }
        return 0;
}
