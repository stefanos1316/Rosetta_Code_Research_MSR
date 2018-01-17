from math import sin, asin

r = 0

for i in xrange(1000000000):
    compose = lambda f, g: lambda x: f( g(x) )
    sin_asin = compose(sin, asin)
    r = sin_asin(0.5)
