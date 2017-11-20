from __future__ import print_function
from multiprocessing import Pool

def main():
    p = Pool()

    for i in range(1000000):
        p.map(print, 'Enjoy Rosetta Code'.split())

if __name__=="__main__":
    main()
