package main

func executeTask(i int) int{

	var flag bool
	flag = isPalindrome("saippuakivikauppias")
	_ = flag
	return i + 1
}

func main() {
	r := int(1)
	for i := 0; i < 1000000000; i++ {
		r = executeTask(i + r)	
	}
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
