package main

import "strconv"

func executeTask(i int) int{
	str := strconv.Itoa(i)
	var flag bool
	flag = isPalindrome("saippuakivikauppias"+str)
	_ = flag
	return i
}

func main() {
	r := int(1)
	for i := 0; i < 1000000000; i++ {
		r = executeTask(i )	
	}
	_=r
}

func isPalindrome(s string) bool {
	runes := []rune(s)
	for len(runes) > 1 {
		if runes[0] != runes[len(runes)-1] {
			return false
		}
		runes = runes[1 : len(runes)-1]
	}
	return true
}
