#include <stdio.h>


int executeTask(int i, FILE *in, FILE *out, int c){
  in = fopen("../input.txt", "r");
  if (!in) {
    fprintf(stderr, "Error opening input.txt for reading.\n");
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

for ( int i = 0; i < 1000000; ++i) {
	r = executeTask(i, &in, &out, c);
}	
  return 0;
}
