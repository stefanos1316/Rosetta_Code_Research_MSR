
r = 1

def executeTask(i):
	arr5 = [1+i, 2-i, 3+i, 4-i, 5+i]
	arr6 = [6+i, 7-i, 8+i, 9-i, 10+i]
	arr6 += arr5
	return i;

for i in xrange(2000000000):
	r = executeTask(i)

