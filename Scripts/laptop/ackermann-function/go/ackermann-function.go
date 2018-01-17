package main

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
    for i := 0; i < 1000000; i++ {
        for m := 0; m <= 3; m++ {
            for n := 0; n <= 3; n++ {
                r = Ackermann(m, n)
            }
        }
    }
 _ = r
}

