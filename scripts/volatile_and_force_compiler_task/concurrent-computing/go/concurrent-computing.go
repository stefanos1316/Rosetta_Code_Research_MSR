package main

import (
    "fmt"
    "math/rand"
    "time"
)

func executeTask(i int) int {

    words := []string{"Enjoy", "Rosetta", "Code"}
    rand.Seed(time.Now().UnixNano())
    q := make(chan string)
    for _, w := range words {
        go func(w string) {
            time.Sleep(time.Duration(rand.Int63n(1)))
            q <- w
        }(w)
    }
    for j := 0; j < len(words); j++ {
	fmt.Println(i, <-q)
    }
return i
}

func main() {
    r := int(1)

    for j := 0; j < 1000000; j++ {
	r = executeTask(j + r)
}
}
