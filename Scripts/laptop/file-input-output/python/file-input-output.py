
def executeTask(i):
	infile = open('../input.txt', 'r')
	outfile = open('output.txt', 'w')
	for line in infile:
   		outfile.write(line)
	outfile.close()
	infile.close()
	return i + 1

r = 1
for i in range(1000000):
	r= executeTask(i + r)
