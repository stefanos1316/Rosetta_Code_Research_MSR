import Foundation 

for i in 1...10000000 {
var originalString = "http://foo bar/" + String(i)
var escapedString = originalString.addingPercentEncoding(withAllowedCharacters: .urlHostAllowed)
}
