// the integration routine

#include <iostream>

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
double f1(double x) { return x*x*x; }
double f2(double x) { return 1/x; }
double f3(double x) { return x; }

int main() {

for ( int i = 0; i < 1000; ++i ) {

// inside a function somewhere:
integrate(f1, 0.0, 1.0, 100, rectangular(rectangular::left));
integrate(f1, 0.0, 1.0, 100, rectangular(rectangular::middle));
integrate(f1, 0.0, 1.0, 100, rectangular(rectangular::right));
integrate(f1, 0.0, 1.0, 100, trapezium());
integrate(f1, 0.0, 1.0, 100, simpson());

integrate(f2, 1.0, 100.0, 1000, rectangular(rectangular::left));
integrate(f2, 1.0, 100.0, 1000, rectangular(rectangular::middle));
integrate(f2, 1.0, 100.0, 1000, rectangular(rectangular::right));
integrate(f2, 1.0, 100.0, 1000, trapezium());
integrate(f2, 1.0, 100.0, 1000, simpson());

integrate(f3, 0.0, 5000.0, 5000000, rectangular(rectangular::left));
integrate(f3, 0.0, 5000.0, 5000000, rectangular(rectangular::middle));
integrate(f3, 0.0, 5000.0, 5000000, rectangular(rectangular::right));
integrate(f3, 0.0, 5000.0, 5000000, trapezium());
integrate(f3, 0.0, 5000.0, 5000000, simpson());

integrate(f3, 0.0, 6000.0, 6000000, rectangular(rectangular::left));
integrate(f3, 0.0, 6000.0, 6000000, rectangular(rectangular::middle));
integrate(f3, 0.0, 6000.0, 6000000, rectangular(rectangular::right));
integrate(f3, 0.0, 6000.0, 6000000, trapezium());
integrate(f3, 0.0, 6000.0, 6000000, simpson());
}

return 0;
}
