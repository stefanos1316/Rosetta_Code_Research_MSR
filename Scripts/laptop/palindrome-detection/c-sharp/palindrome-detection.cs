using System;

class Program
{
    static string Reverse(string value)
    {
        char[] chars = value.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }
 
    static bool IsPalindrome(string value)
    {
        return value == Reverse(value);
    }
 
    private static volatile int r = 0;

    public static int executeTask(int i) {

	IsPalindrome("saippuakivikauppias" + i);
	return i;
    }	

    static void Main(string[] args)
    {
	for (int i = 0; i < 2000000000; ++i)
    		r = executeTask(i);
    }
}
