import re

def executeTask(i):
    string = 'This is a matching string' + `i`
    re.search('string$', string)
    string = re.sub("string", "istyfied", string)
    return i

r = 1
for i in range(10000000):
	r = executeTask(i)
