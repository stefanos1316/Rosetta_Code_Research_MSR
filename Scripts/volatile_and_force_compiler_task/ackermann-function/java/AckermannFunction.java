import java.math.BigInteger;
//import java.util.concurrent;

public class AckermannFunction {

private static int r;

public static int executeTask(int i) {

	int aVar = 0;
	if (i%2 == 0)
		aVar = 1;
	else
		aVar = 2;

        for (long m = 0; m <= 4 - aVar; ++m)
        {
            for (long n = aVar; n <= 3; ++n)
            {
                Ackermann(m,n);
            }
        }
	return i;
}


public static void main(String[] args) {

    for (int i = 0; i < 10000000; ++i) {
	r = executeTask(i);
    }
}

public static long Ackermann(long m, long n)
{
    if(m > 0)
    {
        if (n > 0)
            return Ackermann(m - 1, Ackermann(m, n - 1));
        else if (n == 0)
            return Ackermann(m - 1, 1);
    }
    else if(m == 0)
    {
        if(n >= 0)
            return n + 1;
    }

    return 1;
}


}
