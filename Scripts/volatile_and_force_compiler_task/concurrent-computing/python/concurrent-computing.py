from __future__ import print_function
from multiprocessing import Pool

def executeTask(i):
  	p = Pool()
        p.map(print, 'Enjoy Rosetta Code'.split())
	return i + 1


def main():

    r = 1
    for i in range(1000000):
	r = executeTask(i + r)
if __name__=="__main__":
    main()
