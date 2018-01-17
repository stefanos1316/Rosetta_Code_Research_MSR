using System;
namespace FactorialExample
{
    class Program
    {
    	private static volatile float fact;
        static void Main(string[] args)
        {
		for (int i = 0; i < 1000000000; ++i)
            		fact = Convert.ToSingle(GetFactorial(10));
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
