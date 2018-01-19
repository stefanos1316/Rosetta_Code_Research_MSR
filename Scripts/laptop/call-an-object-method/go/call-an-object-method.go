package main

type MyGoClass struct {
    variable  int // "instance variables"
}

func  someMethod(b *MyGoClass, i int) {
	obj_2 :=&MyGoClass{variable: b.variable + i}
	_ = obj_2
}

func executeTask(i int) int {

	obj := &MyGoClass{variable: 1000}
	someMethod(obj, i)
	return i;
}

func main(){
r := int(1)    

for i := 0; i < 2000000000; i++ {
	r = executeTask(i)
}
_=r

}
