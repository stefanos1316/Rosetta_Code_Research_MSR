package main

func executeTask(i int) int {
 
	aVar := int(0)

	if i%2 == 0 { 
		aVar = 1
	} else {
		aVar = 2
	}
	

        for m := 0; m <= 4 - aVar; m++ {
            for n := aVar; n <= 3; n++ {
                 Ackermann(m, n)
            }
	
       }
	_ = aVar
	return i
}

func Ackermann(m, n int) int {
	switch 0 {
	case m:
		return n + 1
	case n:
		return Ackermann(m - 1, 1)
	}
	return Ackermann(m - 1, Ackermann(m, n - 1))
}

func main() {
    r := int(0)
    for i := 0; i < 10000000; i++ {
	r = executeTask(i)
    }
 _ = r
}

