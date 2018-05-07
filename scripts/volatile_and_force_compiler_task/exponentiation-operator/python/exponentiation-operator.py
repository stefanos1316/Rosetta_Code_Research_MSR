MULTIPLY = lambda x, y: x*y

def executeTask(i):
	return num(2017+i) ** 12 + num(19.88+i) ** 12

class num(float):
    def __pow__(self, b):
        return reduce(MULTIPLY, [self]*b, 1)
r = 1

for i in xrange(2000000000):
	r = executeTask(i)
