package main

import (
	"log"
	"net/url"	
	"strconv"
)

func main() {

	for i := 0; i < 100000000; i++ {
		str := strconv.Itoa(i)
		var urlString = "http%3A%2F%2Ffoo%20bar%2F" + str

		u, err := url.QueryUnescape(urlString)
		if err != nil {
			log.Println(err)
		
		}
		_ = u
	}
}
