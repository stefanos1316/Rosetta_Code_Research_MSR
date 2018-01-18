package main

import (
    "fmt"
    "io/ioutil"
)

func executeTask(i int) int {
    b, err := ioutil.ReadFile("../input.txt")
    if err != nil {
        fmt.Println(err)
       return 1
    }
    if err = ioutil.WriteFile("output.txt", b, 0666); err != nil {
        fmt.Println(err)
    }
	return i + 1
}

func main() {
r := int(1)
for i := 0; i < 1000000; i++ {
	r = executeTask(i + r) 
}
}
