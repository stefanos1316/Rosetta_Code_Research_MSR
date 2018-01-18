package main

import "math"

type ffType func(float64) float64

func compose(f, g ffType) ffType {
    return func(x float64) float64 {
        return f(g(x))
    }
}

func executeTask(i int) float64 {

        sin_asin := compose(math.Sin, math.Asin)
        return sin_asin((float64)(i))
	
}

func main() { 
    	r := float64(0.0)
    	for i := 0; i < 1000000000; i++ {
    		r = executeTask(i)
	}
    _ = r
}
