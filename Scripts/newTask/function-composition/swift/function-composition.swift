import Foundation


func compose<A,B,C>(f: @escaping (B) -> C, g: @escaping (A) -> B) -> (A) -> C {
  return { f(g($0)) } 
}

let sin_asin = compose(f:sin, g:asin)
print(sin_asin(0.5))
