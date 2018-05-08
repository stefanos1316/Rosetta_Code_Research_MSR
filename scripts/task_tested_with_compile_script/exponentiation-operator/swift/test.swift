import Foundation

let pwrInt:(Int,Int)->Double = { a,b in return Double(pow(Double(a),Double(b))) }
let pwrDouble:(Double,Int)->Double = { a,b in return Double(pow(Double(a),Double(b))) }


for i in 0...2000000000 {
	pwrInt(2017+i,12) + pwrDouble(19.88+Double(i),12)
_=i
}

