using System;

class Program
{
    static void Main(string[] args)
    {
        for (double i = 0; i < 1000000000; ++i)
	{
       		Func<double, double> outfunc = Composer<double, double, double>.Compose(functA, functB);
	  	outfunc(0.5);
    	}
	}
  	static double functA(double i) { return Math.Sin(i); }
	static double functB(double i) { return Math.Asin(i); }

//    static double functA(double i) { return i+i; }
  //  static double functB(double i) { return i+i; }


    class Composer<A, B, C>
    {
        public static Func<C, A> Compose(Func<B, A> a, Func<C, B> b)
        {
            return delegate(C i) { return a(b(i)); };
        }
    }
}

