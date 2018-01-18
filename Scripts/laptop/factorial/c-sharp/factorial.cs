using System;
namespace FactorialExample
{
    class Program
    {
    	private static volatile int r;

	public static int executeTask(int i) {

           	GetFactorial(10);
		return i + 1;
	}

        static void Main(string[] args)
        {
		for (int i = 0; i < 2000000000; ++i)
			r = executeTask(i + r);
        }

        private static long GetFactorial(int number)
        {          
            if (number == 0)
            {
                return 1;
            }
            return number * GetFactorial(number-1);
        }
    }
}
