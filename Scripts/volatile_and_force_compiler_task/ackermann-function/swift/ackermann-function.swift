func ackerman(m:Int, n:Int) -> Int {
    if m == 0 {
        return n+1
    } else if n == 0 {
        return ackerman(m:m-1, n:1)
    } else {
        return ackerman(m:m-1, n:ackerman(m:m, n:n-1))
    }
}

for i in 0...10000000 {

    var aVar = 0;
    if i % 2 == 0 {
 	aVar = 1
    } else {
	aVar = 2	
    }

    for m in 0...(4 - aVar) {
        for n in aVar...3 {
           let a = ackerman(m:m,n:n)
	   _ = a
        }
    }
}
