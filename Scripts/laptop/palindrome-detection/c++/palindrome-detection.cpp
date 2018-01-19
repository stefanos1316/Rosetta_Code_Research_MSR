#include <string>
#include <algorithm>

bool is_palindrome(std::string);

int executeTask(int i) {
	
	std::string array = "saippuakivikauppias" + (char)i;
	is_palindrome(array);
	return i;
}

int main() {

	volatile int r;
	for (int i=0; i<2000000000; ++i) {
		r = executeTask(i );
	}
	return 0;
}


bool is_palindrome(std::string s)
{
  return std::equal(s.begin(), s.end(), s.rbegin());
}
