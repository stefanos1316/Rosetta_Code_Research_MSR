using System;

class Program
{

    public static  volatile float r = 0.0f;
    static void Main(string[] args)
    {
        for (float i = 0; i < 1000000000; ++i)
	{
       		Func<float, float> outfunc = Composer<float, float, float>.Compose(functA, functB);
	  	outfunc(i);
    	}
	}
  	static float functA(float i) { return (float)Math.Sin(i); }
	static float functB(float i) { return (float)Math.Asin(i); }

//    static float functA(float i) { return i+i; }
  //  static float functB(float i) { return i+i; }


    class Composer<A, B, C>
    {
        public static Func<C, A> Compose(Func<B, A> a, Func<C, B> b)
        {
            return delegate(C i) { return a(b(i)); };
        }
    }
}

