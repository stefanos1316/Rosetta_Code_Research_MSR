import sys
sys.setrecursionlimit(30000)


def ack1(M, N):
   return (N + 1) if M == 0 else (
      ack1(M-1, 1) if N == 0 else ack1(M-1, ack1(M, N-1)))

for i in range(50):
      for m in range(5):
            for n in range(6-m):
                  print(ack1(m,n))