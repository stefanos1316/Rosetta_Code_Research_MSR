from numpy import *
from math import sin, asin

def executeTask(i):
    compose = lambda f, g: lambda x: f( g(x) )
    sin_asin = compose(sin, asin)
    i = i +1
    return sin_asin(1/i)

r = 0.0
for i in xrange(1000000000):
	r = executeTask(i)
