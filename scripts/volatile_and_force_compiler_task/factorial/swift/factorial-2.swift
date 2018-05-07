func factorial(_ num: Int) -> Int {

    return num < 1 ? 1 : num * factorial(num - 1)
}

for i in 0...100000 {
	let number = 10 +i
	factorial(number)
}
