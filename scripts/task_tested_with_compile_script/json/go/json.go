package main

import "encoding/json"

func executeTask(i int) int {

    		var data interface{}
    		jsonString := json.Unmarshal([]byte(`{"foo":1, "bar":[10, "apples"]}`), &data)
		_ = jsonString
return i + 1
}

func main() {
	r := int(1)
	for i := 0; i < 10000000; i++ {
		r = executeTask(i + r)
	}
	_=r
}
