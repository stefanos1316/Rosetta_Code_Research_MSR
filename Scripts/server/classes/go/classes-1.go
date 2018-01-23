package main

type MyGoClass struct {
    variable  int // "instance variables"
}


func  someMethod(b *MyGoClass, i int) int {
	return b.variable + i
}

func executeTask(i int) int {
	obj := &MyGoClass{variable: 1000}
	someMethod(obj, i)
	return i  +1;
}

func main(){
   	r := int(1)
	for i := 0; i < 2100000000; i++ {
		r = executeTask(i + r)
	}
}
