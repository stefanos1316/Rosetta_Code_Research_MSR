from math import sin, asin

def executeTask(i):
    compose = lambda f, g: lambda x: f( g(x) )
    sin_asin = compose(sin, asin)
    sin_asin(0.5)
    return i + 1

r = 1
for i in xrange(1000000000):
	r = executeTask(i + r)
