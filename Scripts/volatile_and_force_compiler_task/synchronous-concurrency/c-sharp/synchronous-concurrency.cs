using System;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.IO;

namespace SynchronousConcurrency
{
    class Program
    {
	
	private static volatile int r = 1;

	public static int executeTask(int i) {

		
            BlockingCollection<string> toWriterTask = new BlockingCollection<string>();
            BlockingCollection<int> fromWriterTask = new BlockingCollection<int>();
            Task writer = Task.Factory.StartNew(() => ConsoleWriter(toWriterTask, fromWriterTask));
            Task reader = Task.Factory.StartNew(() => FileReader(fromWriterTask, toWriterTask));
            Task.WaitAll(writer, reader);
	    return i + 1;
	} 

       static void Main(string[] args)
        {
            	for (int i = 0; i < 1000;  ++i) {
            		r =executeTask(i + r);
		}
        }
        static void ConsoleWriter(BlockingCollection<string> input, BlockingCollection<int> output)
        {
            int nLines = 0;
            string line;
            while ((line = input.Take()) != null)
            {
                Console.WriteLine(line);
                ++nLines;
            }
            output.Add(nLines);
        }
        static void FileReader(BlockingCollection<int> input, BlockingCollection<string> output)
        {
            StreamReader file = new StreamReader("input.txt"); // TODO: check exceptions
            string line;
            while ((line = file.ReadLine()) != null)
            {
                output.Add(line);

            }
            output.Add(null); // EOF
            Console.WriteLine("line count: " + input.Take());
        }
    }
}
