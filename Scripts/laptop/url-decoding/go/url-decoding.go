package main

import (
	"log"
	"net/url"
)

func executeTask(i int) int {

		var urlString = "http%3A%2F%2Ffoo%20bar%2F"

		u, err := url.QueryUnescape(urlString)
		if err != nil {
			log.Println(err)
		
		}
		_ = u
	return i + 1
}

func main() {

	r := int(1)
	for i := 0; i < 10000000; i++ {
		r = executeTask(i + r)
	}
}
