func factorial(_ num: Int) -> Int {

    return num < 1 ? 1 : num * factorial(num - 1)
}

for i in 0...1000000000 {
	let number = 10
	factorial(number)
}
