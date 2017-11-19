from math import sin, asin

for i in xrange(1000000000):
    compose = lambda f, g: lambda x: f( g(x) )
    sin_asin = compose(sin, asin)
    sin_asin(0.5)