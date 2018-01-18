import re

def executeTask(i):
    string = "This is a matching string"
    re.search('string$', string)
    string = re.sub("string", "istyfied", string)
    return i + 1

r = 1
for i in range(10000000):
	r = executeTask(i + r)
