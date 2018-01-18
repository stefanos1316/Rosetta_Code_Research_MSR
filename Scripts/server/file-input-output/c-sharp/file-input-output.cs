class ReadFromFile
{

    private static volatile int r = 1;

    public static int executeTask(int i) {

	string str = System.IO.File.ReadAllText(@"../input.txt");
	System.IO.File.WriteAllText(@"output.txt", str);
	return i + 1;
    }
	
    static void Main()
    {
	for ( int i = 0; i < 1000000; ++i ) {
		r = executeTask(i + r);
	}
    }
}
