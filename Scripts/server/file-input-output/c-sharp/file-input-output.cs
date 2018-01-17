class ReadFromFile
{

    private static volatile string r;
    static void Main()
    {
	for ( int i = 0; i < 1000000; ++i ) {
	        r = System.IO.File.ReadAllText(@"../input.txt");
		System.IO.File.WriteAllText(@"output.txt", r);
	}
    }
}
