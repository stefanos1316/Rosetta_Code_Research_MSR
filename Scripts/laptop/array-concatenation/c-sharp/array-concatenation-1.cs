using System;

namespace RosettaCode
{
    class Program
    {
            private static volatile int[] a = { 1, 2, 3, 4, 5 };
            private static volatile int[] b = { 6, 7, 8, 9, 10 };

            private static volatile int[] c = new int[a.Length + b.Length];
	    private static volatile int r = 1;
	
	public static int executeTask(int i) {

	    	a.CopyTo(c, 0);
       		b.CopyTo(c, a.Length);
		return i + 1;
	}

        static void Main(string[] args)
        {
            
	    for ( int i =0; i < 2000000000; i++) {
	    	r = executeTask(i + r);
	    }
        }
    }
}
