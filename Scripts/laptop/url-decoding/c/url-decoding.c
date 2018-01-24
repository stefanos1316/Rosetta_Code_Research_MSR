#include <stdio.h>
#include <string.h>

int ishex(int x)
{
	return	(x >= '0' && x <= '9')	||
		(x >= 'a' && x <= 'f')	||
		(x >= 'A' && x <= 'F');
}

int decode(const char *s, char *dec)
{
	char *o;
	const char *end = s + strlen(s);
	int c;

	for (o = dec; s <= end; o++) {
		c = *s++;
		if (c == '+') c = ' ';
		else if (c == '%' && (	!ishex(*s++)	||
					!ishex(*s++)	||
					!sscanf(s - 2, "%2x", &c)))
			return -1;

		if (dec) *o = c;
	}

	return o - dec;
}


int main()
{
	volatile int r = 1;

  	for ( int i = 0; i < 100000000; ++i) {	
		const char *url = "http%3A%2F%2ffoo+bar%2fabcd" + (char)i;
		char str[50];
        	sprintf(str, "%d", i);
        	char final[80];
        	strcpy(final, url);
        	strcat(final, str);
		char out[strlen(final) + 1];
		r = decode(final,0) + i;
	}
	return 0;
}
