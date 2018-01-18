#include <cctype>
#include <iomanip>
#include <sstream>
#include <string>
#include <iostream>

std::string urlDecode(std::string &eString) {
	std::string ret;
	char ch;
	int i, j;
	for (i=0; i<eString.length(); i++) {
		if (int(eString[i])==37) {
			sscanf(eString.substr(i+1,2).c_str(), "%x", &j);
			ch=static_cast<char>(j);
			ret+=ch;
			i=i+2;
		} else {
			ret+=eString[i];
		}
	}
	return (ret);
}

int executeTask(int i) {
	std::string encoded( "http%3A%2F%2Ffoo%20bar%2F" ) ;
	volatile std::string decode = urlDecode(encoded); 

	return 1 + i;
}

int main( ) {
 
 volatile int r = 1;
 for (int i = 0; i < 10000000; ++i) {
 	r = executeTask(i + r);
 }
   return 0 ;
}
