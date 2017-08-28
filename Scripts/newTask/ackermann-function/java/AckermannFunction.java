import java.math.BigInteger;

public class AckermannFunction {


public static void main(String[] args) {

    for (long m = 0; m <= 4; ++m)
    {
        for (long n = 0; n < 6 - m; ++n)
        {
            Ackermann(m,n);
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