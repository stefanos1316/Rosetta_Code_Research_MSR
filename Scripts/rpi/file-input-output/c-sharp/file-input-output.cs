class ReadFromFile
{
    static void Main()
    {
	for ( int i = 0; i < 100000; ++i ) {
	        string text = System.IO.File.ReadAllText(@"../input.txt");
		System.IO.File.WriteAllText(@"../output.txt", text);
	}
    }
}
