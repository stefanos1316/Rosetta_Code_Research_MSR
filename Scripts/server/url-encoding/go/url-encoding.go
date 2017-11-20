package main

import (
 //   "fmt"
    "net/url"
)

func main() {
  for i := 0; i < 100000000; i++ {
    url.QueryEscape("http://foo bar/")
  }
}
