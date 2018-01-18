using System;

class Program
{

    private static volatile int r = 1;
    
    public static int executeTask(int i) {

        Func<float, float> outfunc = Composer<float, float, float>.Compose(functA, functB);
	outfunc((float)i);
 	return 1 + i;
    } 

    static void Main(string[] args)
    {
        for (int i = 0; i < 1000000000; ++i)
	{
		r = executeTask(i + r);
    	}
	}
  	static float functA(float i) { return (float)Math.Sin(i); }
	static float functB(float i) { return (float)Math.Asin(i); }


    class Composer<A, B, C>
    {
        public static Func<C, A> Compose(Func<B, A> a, Func<C, B> b)
        {
            return delegate(C i) { return a(b(i)); };
        }
    }
}

