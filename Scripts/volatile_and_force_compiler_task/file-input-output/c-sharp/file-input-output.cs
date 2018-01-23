class ReadFromFile
{

    private static volatile int r = 1;

    public static int executeTask(int i) {

	string str = System.IO.File.ReadAllText(@"../test_directory/"+i);
	System.IO.File.WriteAllText(@"output.txt", str);
	return i + 1;
    }
	
    static void Main()
    {
	for ( int i = 1; i <= 10000; ++i ) {
		r = executeTask(i);
	}
    }
}
