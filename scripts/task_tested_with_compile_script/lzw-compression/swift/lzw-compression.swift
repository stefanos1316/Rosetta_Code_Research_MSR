import Foundation

class LZW {
  class func compress(uncompressed:String) -> [Int] {
    var dict = [String : Int]()

    for i in 0 ..< 256 {
      let s = String(describing: UnicodeScalar(i))
      dict[s] = i
    }

    var dictSize = 256
    var w = ""
    var result = [Int]()
    for c in uncompressed.characters {
      let wc = w + String(c)
      if dict[wc] != nil {
        w = wc
      } else {
        //result.append(dict[w]!)
        dictSize += 1
	dict[wc] = dictSize
        w = String(c)
      }
    }

    if w != "" {
      result.append(dict[w]!)
    }
    return result
  }

  class func decompress(compressed:[Int]) -> String? {
    var dict = [Int : String]()

    for i in 0 ..< 256 {
      dict[i] = String(describing: UnicodeScalar(i))
    }

    let dictSize = 256
    var w = String(describing: UnicodeScalar(compressed[0]))
    var result = w
    for k in compressed[1 ..< compressed.count] {
      let entry : String
      if let x = dict[k] {
        entry = x
      } else if k == dictSize {
        entry = w + String(describing: w.characters.startIndex)
      } else {
        return nil
      }

      result += entry
      dict[dictSize+1] = w + String(describing: entry.characters.startIndex)
      w = entry
    }
    return result
  }
}
for i in 1...1000000 {
let comp = LZW.compress(uncompressed: "TOBEORNOTTOBEORTOBEORNOT")
 // print(comp) 
comp
if let decomp = LZW.decompress(compressed: comp) {
	decomp 
 //print(decomp)
}
}
