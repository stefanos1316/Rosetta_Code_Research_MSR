package main

type MyGoClass struct {
    variable  int // "instance variables"
}

func  someMethod(b *MyGoClass) {
	obj_2 :=&MyGoClass{variable: b.variable}
	_ = obj_2
}

func executeTask(i int) int {

	obj := &MyGoClass{variable: 1000}
	someMethod(obj)
	return i + 1;
}

func main(){
r := int(1)    

for i := 0; i < 2000000000; i++ {
	r = executeTask(i + r)
}
}
