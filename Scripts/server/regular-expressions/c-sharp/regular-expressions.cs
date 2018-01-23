using System;
using System.Text.RegularExpressions;

class Program {
    
    private static volatile int r;

    public static int executeTask(int i) {
	
	
        string str = "this is a matching string" + i;

        new Regex("string$").IsMatch(str);
        new Regex("string").Replace(str, "istyfied");

	return i;
    }
 
    static void Main(string[] args) {
   
    for (int i = 0; i < 10000000; ++i) {
    		r = executeTask(i );
	}
    }
}
