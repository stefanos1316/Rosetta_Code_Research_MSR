import Foundation

for i in 0...100000000 {
	let encoded = "http%3A%2F%2Ffoo%20bar%2F"+String(i)
	let encodedHost = encoded.removingPercentEncoding
}
