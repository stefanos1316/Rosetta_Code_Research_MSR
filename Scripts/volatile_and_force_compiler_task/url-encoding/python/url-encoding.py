import urllib


for i in range(10000000):
	s ='http://foo/bar/'
	s += `i`
	urllib.quote(s)
