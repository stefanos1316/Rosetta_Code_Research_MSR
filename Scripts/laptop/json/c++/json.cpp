#include <iostream>
#include <iomanip> // std::setw
#include <sstream>
#include <cassert>

#include "json.hpp"

using json = nlohmann::json;

int executeTask(int i) {

	 std::string const expected =  R"delim123({"foo": 1, "bar": {"number": "10", "fruit": "apple"}})delim123";
	 json const jexpected = json::parse( expected );

	json newJson = {{"blue"},{{"number_1","1"}, {"numbe_2","2"}}, {"ocean", "water"}};
	std::stringstream newJson_stream;
    	newJson_stream << std::setw(4) << newJson; 
	
	return i + 1;
}

int main( int argc, char* argv[] )
{
	volatile int r = 0;
	for (int i = 0; i < 10000000; ++i) {
		r = executeTask(i);	
	}
    return 0;
}
