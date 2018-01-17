package main


func factorial(x uint) uint {
	if x == 0 {
		return 1
	}
	
	return x * factorial(x-1)
}

func main() {
	a := uint(0);

 	for i := 0; i < 1000000000; i++ {
	x := uint(10)
	a = factorial(x)
	}
	_=a
}
