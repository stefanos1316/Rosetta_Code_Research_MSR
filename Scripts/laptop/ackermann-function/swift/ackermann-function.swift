func ackerman(m:Int, n:Int) -> Int {
    if m == 0 {
        return n+1
    } else if n == 0 {
        return ackerman(m:m-1, n:1)
    } else {
        return ackerman(m:m-1, n:ackerman(m:m, n:n-1))
    }
}

for i in 0...1000000 {
    for m in 0...3 {
        for n in 0...3 {
           ackerman(m:m,n:n)
        }
    }
}
