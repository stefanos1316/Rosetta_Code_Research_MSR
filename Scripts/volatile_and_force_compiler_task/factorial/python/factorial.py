import sys
sys.setrecursionlimit(200000)

def executeTask(i):
	return factorial(i)

def factorial(n):
    z=1
    if n>1:
        z=n*factorial(n-1)
    return z

r = 1
for i in xrange(100000):
	r = executeTask(i)
