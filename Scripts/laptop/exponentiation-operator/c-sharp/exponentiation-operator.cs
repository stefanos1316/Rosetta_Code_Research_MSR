using System;

class exponentiationOperator {

private static volatile int r = 1;

public static int executeTask(int i) {

	Expon(2017, 12);
	Expon(19.88, 12);
	return i + 1;
}

static void Main(string[] args)
{

for (int i = 0; i < 1000000000; ++i ) {
	r = executeTask(i + r);
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
