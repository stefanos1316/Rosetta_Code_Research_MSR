package main


func factorial(x uint) uint {
	if x == 0 {
		return 1
	}
	
	return x * factorial(x-1)
}

func executeTask(i int) int {
	a := uint(0)
	x := uint(10)
        a = factorial(x)
	_=a
	return i + 1;
}

func main() {
	r := int(1);

 	for i := 0; i < 2000000000; i++ {
		r = executeTask(i + r)
	}
}
