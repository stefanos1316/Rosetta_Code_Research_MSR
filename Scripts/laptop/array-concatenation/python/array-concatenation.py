arr5 = [1, 2, 3, 4, 5]
arr6 = [6, 7, 8, 9, 10]
arr6 += arr5

r = 1

def executeTask(i):
	arr6 = [6, 7, 8, 9, 10]
	arr6 += arr5
	return i + 1;

for i in xrange(2000000000):
	r = executeTask(i + r)

