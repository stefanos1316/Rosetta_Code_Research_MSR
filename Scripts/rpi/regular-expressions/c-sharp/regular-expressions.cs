using System;
using System.Text.RegularExpressions;

class Program {
    static void Main(string[] args) {
    
    for (int i = 0; i < 10000000; ++i) {
        string str = "this is a matching string";

        if (new Regex("string$").IsMatch(str)) { 
        }
        str = new Regex("string").Replace(str, "istyfied");
    }
    }
}
