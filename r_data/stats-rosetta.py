#!/usr/bin/python

# To run the program, type in the command line: python stats-rosetta.py your-file.csv

import sys
import os
from pandas import *
from scipy import stats
import itertools

def main():

	# specify that blank space " " is NaN
	experimentDF = pandas.read_csv(sys.argv[1], sep=' ', na_values=[" "])

	treatment_list = ['treatment1', 'treatment2', 'treatment3']

	# for each of the 14 PLs
	for i in range(14):
		# PL number
		pl_no = i+1

		# dataframes for the treatments (per platform)
		treatment1 = experimentDF[experimentDF["PL"] == pl_no]["VL1"]
		treatment2 = experimentDF[experimentDF["PL"] == pl_no]["VL2"]
		treatment3 = experimentDF[experimentDF["PL"] == pl_no]["VL3"]

		# for each combination of the treatments, apply the test
		pl_pairs = list(itertools.combinations(treatment_list, 2))
		#print pl_pairs
		for k, l in enumerate(pl_pairs):
			entry = pl_pairs[k]
			z_stat, p_val = stats.ranksums(eval(entry[0]), eval(entry[1]))
			print "PL: ", pl_no, "/ Wilcoxon rank sum p for treatments " + entry[0] + " and " + entry[1] + " is: ", p_val
  
if __name__== "__main__":
  main()
