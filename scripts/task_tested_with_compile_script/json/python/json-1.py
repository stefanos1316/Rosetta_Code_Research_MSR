import json


def executeTask(i):
	data = json.loads('{ "foo": 1, "bar": [10, "apples"] }')
	sample = { "blue": [1,2], "ocean": "water" }
	json_string = json.dumps(sample)
	return i + 1

r = 1
for i in range(10000000):
	r = executeTask(i + r)

