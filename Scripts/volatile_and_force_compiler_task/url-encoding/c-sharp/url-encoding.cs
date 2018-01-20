using System;

namespace URLEncode
{
    internal class Program
    {

	private static volatile string r;
	
        private static void Main(string[] args)
        {
		for (int i = 0; i < 10000000; ++i) {
            		r = Encode("http://foo bar/" + i);
		}
	}

        private static string Encode(string uri)
        {
            return Uri.EscapeDataString(uri);
        }
    }
}
