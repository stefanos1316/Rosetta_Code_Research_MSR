package main

import (
    "net/url"
    "strconv"
)



func main() {
  for i := 0; i < 100000000; i++ {
	str := strconv.Itoa(i)
    	url.QueryEscape("http://foo bar/" + str)
  }
}
