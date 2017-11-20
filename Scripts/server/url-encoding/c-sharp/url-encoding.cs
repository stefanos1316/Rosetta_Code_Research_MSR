using System;

namespace URLEncode
{
    internal class Program
    {
        private static void Main(string[] args)
        {
		for (int i = 0; i < 10000000; ++i)
            		Encode("http://foo bar/");
        }

        private static string Encode(string uri)
        {
            return Uri.EscapeDataString(uri);
        }
    }
}
