using System;

namespace URLEncode
{
    internal class Program
    {
	private static volatile int r;
	
	public static int executeTask(int i) {

		string str = Decode("http%3A%2F%2Ffoo%20bar%2F");
		return 1 + i;
	}
	
        private static void Main(string[] args)
        {
		for (int i = 0; i < 10000000; ++i)
        		r = executeTask(i + r);
	}

        private static string Decode(string uri)
        {
            return Uri.UnescapeDataString(uri);
        }
    }
}
