#include <stdio.h>
#include <string.h>

int executeTask(int i, FILE *in, FILE *out, int c){

  char *fileLocation = "../test_directory/";
  char str[50];
  sprintf(str, "%d", i);
 
  char final[30];
  strcpy(final, fileLocation);
  strcat(final, str);  

  in = fopen(final, "r");
  if (!in) {
    fprintf(stderr, "Error opening %d for reading.\n",i);
    return 1;
  }

  out = fopen("output.txt", "w");
  if (!out) {
    fprintf(stderr, "Error opening output.txt for writing.\n");
    fclose(in);
    return 1;
  }

  while ((c = fgetc(in)) != EOF) {
    fputc(c, out);
  }

  fclose(out);
  fclose(in);
  return i;
}

int main(int argc, char **argv) {
  volatile FILE *in, *out;
  volatile int c;
  volatile int r;

for ( int i = 1; i <= 10000; ++i) {
	r = executeTask(i, &in, &out, c);
}	
  return 0;
}
