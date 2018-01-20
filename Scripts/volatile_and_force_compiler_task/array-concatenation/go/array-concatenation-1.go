package main

func executeTask(i int) int {

   	a := []int{1+i, 2-i, 3+i, 4-i ,5+i}
    	b := []int{6+i, 7-i, 8+i, 9-i, 10+i} // these are technically slices, not arrays
	c := append(a, b...)
	_ = c

	return i;
}

func main() {
	r := int(1)
	for i := 0; i < 2000000000; i++ {
		r = executeTask(i)
	}
	_=r
}
