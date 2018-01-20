import urllib


for i in range(100000000):
	urllib.unquote("http%3A%2F%2Ffoo%20bar%2F" + `i`)
