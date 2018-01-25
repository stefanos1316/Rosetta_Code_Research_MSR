using System;
using System.Threading;

class Concurrent {

private static volatile int r = 1;

public static int executeTask(int i) {

	Thread t = new Thread(new ParameterizedThreadStart(WriteText));
	t.Start(i + " Enjoy");
 
	t = new Thread(new ParameterizedThreadStart(WriteText));
	t.Start(i + " Rosetta");
 
	t = new Thread(new ParameterizedThreadStart(WriteText));
	t.Start(i + " Code");	
	return i;
}

static void Main(string[] args)
{
	for ( int i = 0; i < 1000000; ++i ) {
		r = executeTask(i);
	}
}
 
private static void WriteText(object p)
{
	Thread.Sleep(1);
	Console.WriteLine(p);
}
}
