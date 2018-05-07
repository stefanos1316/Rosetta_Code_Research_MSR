import sys
sys.setrecursionlimit(30000)

r = 1
aVar = 0

def executeTask(i):
      	if (i%2 == 0):
		aVar = 1
	else:
		aVar = 2
	
	for m in range(5 - aVar):
        	for aVar in range(4):
                  	ack1(m,aVar)
	return i

def ack1(M, N):
   return (N + 1) if M == 0 else (
      ack1(M-1, 1) if N == 0 else ack1(M-1, ack1(M, N-1)))

for i in range(10000000):
	r = executeTask(i)
