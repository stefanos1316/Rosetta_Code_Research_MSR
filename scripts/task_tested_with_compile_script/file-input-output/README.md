# Call an object method

Explanatio in this [link](http://rosettacode.org/mw/index.php?title=File_input/output&redirect=no)

Create a file called   "output.txt",   and place in it the contents of the file   "input.txt",   via an intermediate variable.

In other words, your program will demonstrate:

*  how to read from a file into a variable
*  how to write a variable's contents into a file

Oneliners that skip the intermediate variable are of secondary interest — operating systems have copy commands for that. 

As our test case we used 10,000 random binary content generate files.
To do that, use the create-test-directory.sh script found https://github.com/stefanos1316/BigData/tree/master/test-data
Use parameter such as --dirsize 100000 --filesize 10  --disperasion 0, this will generate 10,000 files with size of 10KBytes.
Then move the directory just under the Rosetta_Code_Research_MSR directory
