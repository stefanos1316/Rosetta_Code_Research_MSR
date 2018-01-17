#include <stdio.h>
#include <assert.h>

int ipow(int base, int exp)
{
   int pow = base;
   int v = 1;
   if (exp < 0) {
      assert (base != 0);  /* divide by zero */
      return (base*base != 1)? 0: (exp&1)? base : 1;
   }

   while(exp > 0 )
   {
      if (exp & 1) v *= pow;
      pow *= pow;
      exp >>= 1;
    }
   return v;
}

double dpow(double base, int exp)
{
   double v=1.0;
   double pow = (exp <0)? 1.0/base : base;
   if (exp < 0) exp = - exp;

   while(exp > 0 )
   {
      if (exp & 1) v *= pow;
      pow *= pow;
      exp >>= 1;
   }
   return v;
}

int main()
{

volatile int r1 = 0; 
volatile double r2 = 0.0;

for ( int i = 0; i < 1000000000; ++i) {
   r1 = ipow(2017,12);
   r2 = dpow(19.88,12);
}
return 0;
}
