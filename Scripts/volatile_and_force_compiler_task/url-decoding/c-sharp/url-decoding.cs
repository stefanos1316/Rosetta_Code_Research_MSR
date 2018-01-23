using System;

namespace URLEncode
{
    internal class Program
    {
	private static volatile string r = "";
	
        private static void Main(string[] args)
        {
		for (int i = 0; i < 100000000; ++i) {
			r = Decode("http%3A%2F%2Ffoo%20bar%2F" + i);
		}
	}

        private static string Decode(string uri)
        {
            return Uri.UnescapeDataString(uri);
        }
    }
}
