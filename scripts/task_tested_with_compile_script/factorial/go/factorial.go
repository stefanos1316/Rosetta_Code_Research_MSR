package main

func factorial(x uint) uint {
	if x == 0 {
		return 1
	}
	
	return x * factorial(x-1)
}

func executeTask(i int) uint {
	u := uint(i)
	return factorial(u)
}

func main() {
	r := uint(1);

 	for i := 0; i < 100000; i++ {
		r = executeTask(i)
	}
	_=r
}
