using System;
using System.Threading;

class Concurrent {
 
static void Main(string[] args)
{
	for ( int i = 0; i < 1000000; ++i ) {

	Thread t = new Thread(new ParameterizedThreadStart(WriteText));
	t.Start("Enjoy");
 
	t = new Thread(new ParameterizedThreadStart(WriteText));
	t.Start("Rosetta");
 
	t = new Thread(new ParameterizedThreadStart(WriteText));
	t.Start("Code");	
}
}
 
private static void WriteText(object p)
{
	Thread.Sleep(1);
	Console.WriteLine(p);
}
}