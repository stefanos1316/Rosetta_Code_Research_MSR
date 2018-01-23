using System;
using System.Threading;

class Concurrent {

private static volatile int r = 1;

public static int executeTask(int i) {

	Thread t = new Thread(new ParameterizedThreadStart(WriteText));
	t.Start("Enjoy");
 
	t = new Thread(new ParameterizedThreadStart(WriteText));
	t.Start("Rosetta");
 
	t = new Thread(new ParameterizedThreadStart(WriteText));
	t.Start("Code");	
	return i + 1;
}

static void Main(string[] args)
{
	for ( int i = 0; i < 1000000; ++i ) {
		r = executeTask(i + r);
	}
}
 
private static void WriteText(object p)
{
	Thread.Sleep(1);
	Console.WriteLine(p);
}
}
