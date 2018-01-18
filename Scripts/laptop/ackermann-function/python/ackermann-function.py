import sys
sys.setrecursionlimit(30000)

r = 1

def executeTask(i):
      	for m in range(4):
        	for n in range(4):
                  	ack1(m,n)
	return i + 1

def ack1(M, N):
   return (N + 1) if M == 0 else (
      ack1(M-1, 1) if N == 0 else ack1(M-1, ack1(M, N-1)))

for i in range(1000000):
	r = executeTask(i + r)
