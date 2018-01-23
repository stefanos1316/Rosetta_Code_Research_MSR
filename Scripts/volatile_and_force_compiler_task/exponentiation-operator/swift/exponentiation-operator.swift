import Foundation

infix operator ** { associativity left precedence 170 }

func ** (num: Double, power: Double) -> Double{
    return pow(num, power)
}

for i in 0...2000000000 {
	2017**12
	19.88**12
}
