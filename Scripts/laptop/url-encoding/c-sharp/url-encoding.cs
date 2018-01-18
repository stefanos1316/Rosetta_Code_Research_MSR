using System;

namespace URLEncode
{
    internal class Program
    {

	private static volatile int r = 1;
	
	public static int executeTask(int i) {

            	string str = Encode("http://foo bar/");
		return i + 1;
	}
	
        private static void Main(string[] args)
        {
		for (int i = 0; i < 10000000; ++i)
        		r = executeTask(i + r);
	}

        private static string Encode(string uri)
        {
            return Uri.EscapeDataString(uri);
        }
    }
}
