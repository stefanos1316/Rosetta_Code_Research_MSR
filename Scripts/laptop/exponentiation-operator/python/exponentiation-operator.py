MULTIPLY = lambda x, y: x*y

class num(float):
    # the following method has complexity O(b)
    # rather than O(log b) via the rapid exponentiation
    def __pow__(self, b):
        return reduce(MULTIPLY, [self]*b, 1)

for i in xrange(1000000000):
	num(2017) ** 12
 	num(19.88) ** 12
