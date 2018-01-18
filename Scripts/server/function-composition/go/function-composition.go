package main

import "math"

type ffType func(float64) float64

func compose(f, g ffType) ffType {
    return func(x float64) float64 {
        return f(g(x))
    }
}

func executeTask(i int) int {

        sin_asin := compose(math.Sin, math.Asin)
        sin_asin((float64)(i))
	return i + 1
}

func main() { 
    	r := int(1)
    	for i := 0; i < 1000000000; i++ {
    		r = executeTask(i + r)
	}
    _ = r
}
