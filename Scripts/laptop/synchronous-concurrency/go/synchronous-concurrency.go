package main

import (
    "bufio"
    "fmt"
    "log"
    "os"
)

func executeTask(i int) int {

    lines := make(chan string)
    count := make(chan int)
    go func() {
        c := 0
        for l := range lines {
            fmt.Println(l)
            c++
        }
        count <- c
    }()

    f, err := os.Open("input.txt")
    if err != nil {
        log.Fatal(err)
    }
    for s := bufio.NewScanner(f); s.Scan(); {
        lines <- s.Text()
    }
    f.Close()
    close(lines)
    fmt.Println("Number of lines:", <-count)
	return i + 1
}

func main() {
    r := int(1)
    for i := 0; i < 1000; i++ {
	r = executeTask(i + r)	
    }
}
