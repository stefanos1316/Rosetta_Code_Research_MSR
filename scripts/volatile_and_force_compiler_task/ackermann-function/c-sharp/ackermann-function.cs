using System;
class Program
{

    private static volatile int r = 0;

    public static int executeTask(int i) {

	    long aVar = 0;
            if (i%2 == 0)	    
		aVar = 1;
	    else
		aVar = 2;

            for (long m = 0; m <= 4 - aVar; ++m)
            {
                for (long n = aVar; n <= 3; ++n)
                {
                  Ackermann(m, n);
                }
            }
	return i;	
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

        throw new System.ArgumentOutOfRangeException();
    }

    static void Main()
    {
       	for (int i = 0; i < 10000000; ++i) {
    		r = executeTask(i);
	}
    }
}
