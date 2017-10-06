import Foundation 

for i in 1...10000000 {
var originalString = "http://foo bar/"
var escapedString = originalString.addingPercentEncoding(withAllowedCharacters: .urlHostAllowed)
//print(escapedString!)
}
