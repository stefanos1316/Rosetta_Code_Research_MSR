#include <stdio.h>
#include <ctype.h>

char rfc3986[256] = {0};
char html5[256] = {0};

/* caller responsible for memory */
int encode(const char *s, char *enc, char *tb)
{
	for (; *s; s++) {
		if (tb[*s]) sprintf(enc, "%c", tb[*s]);
		else        sprintf(enc, "%%%02X", *s);
		while (*++enc);
	}

	return 1;
}

int executeTask(int j) {
	const char *url = "http://foo bar/";
	char str[50];
	sprintf(str, "%d", j);
	char final[80];
  	strcpy(final, url);
  	strcat(final, str);
	char enc[(strlen(final) * 3) + 1];

	int i;
	for (i = 0; i < 256; i++) {
		rfc3986[i] = isalnum(i)||i == '~'||i == '-'||i == '.'||i == '_'
			? i : 0;
		html5[i] = isalnum(i)||i == '*'||i == '-'||i == '.'||i == '_'
			? i : (i == ' ') ? '+' : 0;
	}

	return encode(final, enc, rfc3986) + j;
}

int main()
{
    	volatile int r = 0;
    	for (int i = 0; i < 10000000; ++i) {
		r = executeTask(i);
	}
	return 0;
}
