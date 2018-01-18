import urllib

def executeTask(i):
	urllib.unquote("http%3A%2F%2Ffoo%20bar%2F")
	return i + 1

r = 1

for i in range(10000000):
	r = executeTask(i + r)
