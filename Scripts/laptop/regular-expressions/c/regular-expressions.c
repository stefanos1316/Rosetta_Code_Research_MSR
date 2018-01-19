#include <stdio.h>
#include <stdlib.h>
#include <sys/types.h>
#include <regex.h>
#include <string.h>

int executeTask(int i) {
   regex_t preg;
   regmatch_t substmatch[1];
   const char *tp = "string$";
   const char *t1 = "this is a matching string" + (char)i;
   const char *ss = "istyfied";

   regcomp(&preg, "string$", REG_EXTENDED);

   if ( (regexec(&preg, t1, 0, NULL, 0)==0)) {}
   regfree(&preg);
   regcomp(&preg, "a[a-z]+", REG_EXTENDED);
   if ( regexec(&preg, t1, 1, substmatch, 0) == 0 )
   {
      substmatch[0].rm_so;
      substmatch[0].rm_eo;
     
      char *ns = malloc(substmatch[0].rm_so + 1 + strlen(ss) +
                        (strlen(t1) - substmatch[0].rm_eo) + 2);
      memcpy(ns, t1, substmatch[0].rm_so+1);
      memcpy(&ns[substmatch[0].rm_so], ss, strlen(ss));
      memcpy(&ns[substmatch[0].rm_so+strlen(ss)], &t1[substmatch[0].rm_eo],
                strlen(&t1[substmatch[0].rm_eo]));
      ns[ substmatch[0].rm_so + strlen(ss) +
          strlen(&t1[substmatch[0].rm_eo]) ] = 0;
      free(ns);
   } else {
      //printf("the string '%s' is the same: no matching!\n", t1);
   }
   regfree(&preg);

   return i;
}


int main()
{
	volatile int r = 1;
	for (int i = 0; i < 10000000; ++i ) {
 		r = executeTask(i);
	}
   return 0;
}
