g++49 -O3 -fomit-frame-pointer -c test_timing.cpp
gcc49 -O3 -fomit-frame-pointer -o libco.o -c ../libco.c
g++49 -O3 -fomit-frame-pointer -o test_timing libco.o test_timing.o
rm -f *.o
