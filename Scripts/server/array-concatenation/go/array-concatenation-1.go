package main

func executeTask(i int) int {

   	a := []int{1, 2, 3, 4 ,5}
    	b := []int{6, 7, 8, 9, 10} // these are technically slices, not arrays
	c := append(a, b...)
	_ = c

	return i + 1;
}

func main() {
	r := int(1)
	for i := 0; i < 2000000000; i++ {
		r = executeTask(i + r)
	}

}
