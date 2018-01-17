using System;
using System.Text.RegularExpressions;

class Program {
    
    private static volatile string tr;
    private static volatile bool ma;   
 
    static void Main(string[] args) {
    
    for (int i = 0; i < 10000000; ++i) {
        string str = "this is a matching string";

        ma = new Regex("string$").IsMatch(str);
        tr = new Regex("string").Replace(str, "istyfied");
    }
    }
}
