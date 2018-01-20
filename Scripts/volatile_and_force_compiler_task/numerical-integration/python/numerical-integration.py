from fractions import Fraction

aVar=0

def left_rect(f,x,h):
  return f(x)

def mid_rect(f,x,h):
  return f(x + h/2)

def right_rect(f,x,h):
  return f(x+h)

def trapezium(f,x,h):
  return (f(x) + f(x+h))/2.0

def simpson(f,x,h):
  return (f(x) + 4*f(x + h/2) + f(x+h))/6.0

def cube(x):
  return (x*x*x+aVar)

def reciprocal(x):
  return 1/(x+aVar)

def identity(x):
  return x+aVar

def integrate( f, a, b, steps, meth):
   h = (b-a)/steps
   ival = h * sum(meth(f, a+i*h, h) for i in range(steps))
   return ival

# Tests
r = 1

def executeTask(i):
  integrate(cube,0,1,100,left_rect)
  integrate(cube,0,1,100,mid_rect)
  integrate(cube,0,1,100,right_rect)
  integrate(cube,0,1,100,trapezium)
  integrate(cube,0,1,100,simpson)

  integrate(reciprocal,1,100,1000,left_rect)
  integrate(reciprocal,1,100,1000,mid_rect)
  integrate(reciprocal,1,100,1000,right_rect)
  integrate(reciprocal,1,100,1000,trapezium)
  integrate(reciprocal,1,100,1000,simpson)

  integrate(identity,0,5000,5000000,left_rect)
  integrate(identity,0,5000,5000000,mid_rect)
  integrate(identity,0,5000,5000000,right_rect)
  integrate(identity,0,5000,5000000,trapezium)
  integrate(identity,0,5000,5000000,simpson)

  integrate(identity,0,6000,6000000,left_rect)
  integrate(identity,0,6000,6000000,mid_rect)
  integrate(identity,0,6000,6000000,right_rect)
  integrate(identity,0,6000,6000000,trapezium)
  integrate(identity,0,6000,6000000,simpson)

  return i + 1

for aVar in range(100):
	r = executeTask(aVar)
