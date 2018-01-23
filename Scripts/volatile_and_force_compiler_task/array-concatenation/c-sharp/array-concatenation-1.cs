using System;

namespace RosettaCode
{
    class Program
    {

	    private static volatile int r = 1;

	public static int executeTask(int i) {
            	int[] a = { 1+i, 2-i, 3+i, 4-i, 5+i };
            	int[] b = { 6+i, 7-i, 8+i, 9-i, 10+i };
           	int[] c = new int[a.Length + b.Length];
	    	a.CopyTo(c, 0);
       		b.CopyTo(c, a.Length);
		return i;
	}

        static void Main(string[] args)
        {
            
	    for ( int i =0; i < 2000000000; i++) {
	    	r = executeTask(i);
	    }
        }
    }
}
