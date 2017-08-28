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
    for i := 0; i <= 50; i++ {
        for m := 0; m <= 4; m++ {
            for n := 0; n < 6 - m; n++ {
                Ackermann(m, n)
            }
        }
    }

}

