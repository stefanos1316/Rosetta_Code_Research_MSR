package main

import (
 //   "fmt"
    "net/url"
)

func executeTask(i int) int {
	
    url.QueryEscape("http://foo bar/")
	return i + 1
}

func main() {
  r := int(1)
  for i := 0; i < 100000000; i++ {
  	r = executeTask(i + r)
  }
}
