package main

import (
    "fmt"
    "io/ioutil"
    "strconv"
)

func executeTask(i int) int {
    str := strconv.Itoa(i)
    fileLocation := "../test_directory/" + str
    b, err := ioutil.ReadFile(fileLocation)
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
	for i := 1; i <= 10000; i++ {
		r = executeTask(i) 
	}
	_=r
}
