package main

import (
    "errors"
)

func expI(b, p int) (int, error) {
    if p < 0 {
        return 0, errors.New("negative power not allowed")
    }
    r := 1
    for i := 1; i <= p; i++ {
        r *= b
    }
    return r, nil
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

func main() {

r1 := int(0);
r2 := float32(0.0);

for i := 0; i < 1000000000; i++ {
     expI(2017, 12)
    r2 = expF(19.88, 12)
}
_=r1
_=r2
}
