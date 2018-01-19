#include <string.h>

int palindrome(const char*);

int executeTask(int i) {
	char* array = "saippuakivikauppias" + (char)i;
	palindrome(array);

   return i;
}

int main() {

   	volatile int r = 1;
	for (int i=0; i<2000000000; ++i) {
		r = executeTask(i);
	}
	return 0;
}

int palindrome(const char *s)
{
   int l;
   l = strlen(s);
   for(int i=0; i<l/2; i++)
   {
     if ( s[i] != s[l-i-1] ) return 0;
   }
   return 1;
}
