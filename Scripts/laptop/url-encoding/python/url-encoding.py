import urllib

def executeTask(i):
	s = 'http://foo/bar/'
	s = urllib.quote(s)
	return i + 1

r = 1

for i in range(10000000):
	r = executeTask(i +r)
