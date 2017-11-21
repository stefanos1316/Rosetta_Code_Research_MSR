package main

import "math"

type ffType func(float64) float64

func compose(f, g ffType) ffType {
    return func(x float64) float64 {
        return f(g(x))
    }
}

func main() {
    for i := 0; i < 100000000; i++ {
        sin_asin := compose(math.Sin, math.Asin)
        sin_asin(.5)
    }
}
