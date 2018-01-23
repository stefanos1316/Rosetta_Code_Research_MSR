
def executeTask(i):
	s = '../test_directory/' + `i`
	infile = open(s, 'r')
	outfile = open('output.txt', 'w')
	for line in infile:
   		outfile.write(line)
	outfile.close()
	infile.close()
	return i

r = 1
for i in range(10000):
	r = executeTask(i+1)
