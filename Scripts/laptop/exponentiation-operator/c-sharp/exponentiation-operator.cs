using System;

class exponentiationOperator {


private static volatile float r1;
private static volatile float r2;

static void Main(string[] args)
{

for (int i = 0; i < 1000000000; ++i ) {
	r1 = (float)Expon(2017, 12);
	r2 = (float)Expon(19.88, 12);
}
}
 
static double Expon(int Val, int Pow) 
{
	return Math.Pow(Val, Pow);
}
static double Expon(double Val, int Pow)
{
	return Math.Pow(Val, Pow);
}
}
