// the integration routine

#include <iostream>

double aVar=0;

template<typename Method, typename F, typename Float>
 double integrate(F f, Float a, Float b, int steps, Method m)
{
  double s = 0;
  double h = (b-a)/steps;
  for (int i = 0; i < steps; ++i)
    s += m(f, a + h*i, h);
  return h*s;
}

// methods
class rectangular
{
public:
  enum position_type { left, middle, right };
  rectangular(position_type pos): position(pos) {}
  template<typename F, typename Float>
   double operator()(F f, Float x, Float h) const
  {
    switch(position)
    {
    case left:
      return f(x);
    case middle:
      return f(x+h/2);
    case right:
      return f(x+h);
    }
  }
private:
  const position_type position;
};

class trapezium
{
public:
  template<typename F, typename Float>
   double operator()(F f, Float x, Float h) const
  {
    return (f(x) + f(x+h))/2;
  }
};

class simpson
{
public:
  template<typename F, typename Float>
   double operator()(F f, Float x, Float h) const
  {
    return (f(x) + 4*f(x+h/2) + f(x+h))/6;
  }
};

// sample usage
double f1(double x) { return (x*x*x)+aVar; }
double f2(double x) { return 1/(x+aVar); }
double f3(double x) { return x+aVar; }

int executeTask(int r) {
r = integrate(f1, 0.0, 1.0, 100, rectangular(rectangular::left));
r = integrate(f1, 0.0, 1.0, 100, rectangular(rectangular::middle));
r = integrate(f1, 0.0, 1.0, 100, rectangular(rectangular::right));
r = integrate(f1, 0.0, 1.0, 100, trapezium());
r = integrate(f1, 0.0, 1.0, 100, simpson());

r = integrate(f2, 1.0, 100.0, 1000, rectangular(rectangular::left));
r = integrate(f2, 1.0, 100.0, 1000, rectangular(rectangular::middle));
r = integrate(f2, 1.0, 100.0, 1000, rectangular(rectangular::right));
r = integrate(f2, 1.0, 100.0, 1000, trapezium());
r = integrate(f2, 1.0, 100.0, 1000, simpson());

r = integrate(f3, 0.0, 5000.0, 5000000, rectangular(rectangular::left));
r = integrate(f3, 0.0, 5000.0, 5000000, rectangular(rectangular::middle));
r = integrate(f3, 0.0, 5000.0, 5000000, rectangular(rectangular::right));
r = integrate(f3, 0.0, 5000.0, 5000000, trapezium());
r = integrate(f3, 0.0, 5000.0, 5000000, simpson());

r = integrate(f3, 0.0, 6000.0, 6000000, rectangular(rectangular::left));
r = integrate(f3, 0.0, 6000.0, 6000000, rectangular(rectangular::middle));
r = integrate(f3, 0.0, 6000.0, 6000000, rectangular(rectangular::right));
r = integrate(f3, 0.0, 6000.0, 6000000, trapezium());
r = integrate(f3, 0.0, 6000.0, 6000000, simpson());
	

	return 1 + r;
}

int main() {

	volatile double r;
	for ( aVar = 0; aVar < 100; ++aVar ) {
		r = executeTask(aVar);
	}

return 0;
}
