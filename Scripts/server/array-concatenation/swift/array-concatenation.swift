func executeTask(i: Int) -> Int {

let array1 = [1+i,2-i,3+i,4-i,5+i]
let array2 = [6+i,7-i,8+i,9-i,10+i]

let array3 = array1 + array2
_=array3
return i
}

var r = 1
for i in 1...2000000000 {
	r = executeTask(i:i)
}
