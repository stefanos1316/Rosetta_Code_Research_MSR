#include <iostream>
#include <string>
#include <regex>

int main ()
{
  volatile bool m;

  for ( int i = 0; i < 10000000; ++i ) { 
  std::string base="this is a test string";
  std::string str=base; 

    m = std::regex_match (base, std::regex("(.*)(string)"));
    str.replace(str.begin()+15,str.begin()+23,"istyfied"); 
  }

  return 0;
}
