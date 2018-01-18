#include <iostream>
#include <sstream>
#include <string>
 
using std::cout;
using std::endl;
 
std::string urlencode(const std::string &c);

int executeTask(int i) {

    	std::string address = "http://foo bar/";
     	urlencode(address);
	return i + 1;
}

int main(int argc, char *argv[])
{
	volatile int r = 0;
	for (int i = 0; i < 10000000; ++i) {
  		r = executeTask(i + r);
	}
}

std::string urlencode(const std::string &s)
{
    static const char lookup[]= "0123456789abcdef";
    std::stringstream e;
    for(int i=0, ix=s.length(); i<ix; i++)
    {
        const char& c = s[i];
        if ( (48 <= c && c <= 57) ||//0-9
             (65 <= c && c <= 90) ||//abc...xyz
             (97 <= c && c <= 122) || //ABC...XYZ
             (c=='-' || c=='_' || c=='.' || c=='~') 
        )
        {
            e << c;
        }
        else
        {
            e << '%';
            e << lookup[ (c&0xF0)>>4 ];
            e << lookup[ (c&0x0F) ];
        }
    }
    return e.str();
}
