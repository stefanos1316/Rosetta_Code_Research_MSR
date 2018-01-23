package main

func expI(b, p int) int {
    r := 1
    for i := 1; i <= p; i++ {
        r *= b
    }
    return r
}

func expF(b float32, p int) float32 {
    var neg bool
    if p < 0 {
        neg = true
        p = -p
    }
    r := float32(1)
    for pow := b; p > 0; pow *= pow {
        if p&1 == 1 {
            r *= pow
        }
        p >>= 1
    }
    if neg {
        r = 1 / r
    }
    return r
}

func executeTask(i int) int {

    return  expI(2017+i, 12) +  int(expF(19.88+float32(i), 12));
}

func main() {

r := int(1);

for i := 0; i < 2000000000; i++ {
	r = executeTask(i)
}
_=r
}
