import Foundation

for i in 0...10000000 {
let string = "this is a matching string" + String(i)
if string.range(of:"string") != nil { 
}

let newString = string.replacingOccurrences(of: "string", with: "istyfied")
_ = newString
}
