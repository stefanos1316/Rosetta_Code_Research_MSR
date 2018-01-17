import java.math.BigInteger;
//import java.util.concurrent;

public class AckermannFunction {

private static long r;

public static void main(String[] args) {

    for (int i = 0; i < 1000000; ++i) {
        for (long m = 0; m <= 3; ++m)
        {
            for (long n = 0; n <= 3; ++n)
            {
                r = Ackermann(m,n);
            }
        }
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
