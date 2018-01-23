#include <iostream>
#include <string>
#include <regex>
#include <cstring>

int executeTask(int i) {

  	std::string base="this is a test string";
  	std::string str=base; 
    	std::regex_match (base, std::regex("(.*)(string)"));
    	str.replace(str.begin()+15,str.begin()+23,"istyfied"); 
	return i + 1;
}

int main ()
{
  	volatile int r;
  	for ( int i = 0; i < 10000000; ++i ) { 
  		r = executeTask(i + r);
	}

  return 0;
}
