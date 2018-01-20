using System;
namespace FactorialExample
{
    class Program
    {
    	private static volatile float r;

	public static float executeTask(int i) {
			return Convert.ToSingle(GetFactorial(i));
		
	}

        static void Main(string[] args)
        {
		for (int i = 0; i < 100000; ++i)
			r =executeTask(i);
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
