using System;

class exponentiationOperator {

private static volatile int r = 1;

public static int executeTask(int i) {

	return (int)Expon(2017+i, 12) + (int)Expon(19.88 + (double)i, 12);
}

static void Main(string[] args)
{

for (int i = 0; i < 2000000000; ++i ) {
	r = executeTask(i);
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
