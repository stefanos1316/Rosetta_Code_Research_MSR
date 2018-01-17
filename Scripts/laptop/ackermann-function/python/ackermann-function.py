import sys
sys.setrecursionlimit(30000)


def ack1(M, N):
   return (N + 1) if M == 0 else (
      ack1(M-1, 1) if N == 0 else ack1(M-1, ack1(M, N-1)))

r = 0

for i in range(1000000):
      for m in range(4):
            for n in range(4):
                  r = ack1(m,n)
