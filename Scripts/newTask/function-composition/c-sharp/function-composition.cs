using System;

class Program
{
    static void Main(string[] args)
    {
        Func<double, double> outfunc = Composer<double, double, double>.Compose(functA, functB);
        for (double i = 0; i < 1000000000; ++i)
	  	outfunc(0.5);
    }
    static double functA(double i) { return Math.Sin(i); }
    static double functB(double i) { return Math.Asin(i); }
    class Composer<A, B, C>
    {
        public static Func<C, A> Compose(Func<B, A> a, Func<C, B> b)
        {
            return delegate(C i) { return a(b(i)); };
        }
    }
}

